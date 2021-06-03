using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPv6
{
    public class Process
    {
        public int id;
        public string name;
        public int workingTime;//общее время его выполнения
        public Action method;//задача процесса
        public string nameMethod;
        public ProcessState processState;
        public string description;

        public static int lastId;

        public Process(string name, string nameMethod, int time, Action method, string description, int id = -1)
        {
            if (id != -1)
                this.id = id;
            else
            {
                this.id = lastId;
                lastId++;
            }
            this.name = name;
            workingTime = time;
            this.method = method;
            this.nameMethod = nameMethod;
            processState = ProcessState.В_очереди;
            this.description = description;
        }
        public override string ToString()
        {
            return $"{id}.\"{name}\"";
        }
    }
}
