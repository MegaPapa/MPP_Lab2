using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Threading;

namespace MPP_DTOGenerator {

    class DTOGenerator {

        //List<DTOContainer> list;
        private volatile int index;
        private volatile Object threadLock;
        private const byte MAX_THREAD_COUNT = 10;

        public DTOGenerator() {
            threadLock = new Object();
            index = 0;
        }

        public DTO parseJSON(String path) {
            DTO result;
            FileStream stream = new FileStream(@path,FileMode.Open);
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(DTO));
            result = (DTO)serializer.ReadObject(stream);
            return result;
            
        }

        private void createCSFile(object state,DTO dtoObject) {
            threadSafeExecute(null);
        
        }

        private DTOContainer threadSafeExecute(DTO dtoObject) {
            lock (threadLock) {
                DTOContainer tmpContainer = new DTOContainer();
                tmpContainer = dtoObject.Items.ElementAt(index);
                index++;
                return tmpContainer;
            }
        }

        public void startGenerating(DTO dtoObject) {
            ThreadPool.SetMaxThreads(MAX_THREAD_COUNT, MAX_THREAD_COUNT);
            for (int i = 0; i < dtoObject.Items.Count; i++ )
                ThreadPool.QueueUserWorkItem(createCSFile);
            
        }


    }
}
