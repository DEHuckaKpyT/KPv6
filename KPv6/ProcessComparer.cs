using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPv6
{
    public class ProcessComparer : Comparer<Process>
    {
        public override int Compare(Process p1, Process p2)
        {
            if (p1.processState == ProcessState.Выполняется && p2.processState == ProcessState.В_очереди) return -1;
            if (p2.processState == ProcessState.Выполняется && p1.processState == ProcessState.В_очереди) return 1;
            if (p1.processState == ProcessState.Выполняется && p2.processState == ProcessState.Заблокирован) return -1;
            if (p2.processState == ProcessState.Выполняется && p1.processState == ProcessState.Заблокирован) return 1;
            if (p1.processState == ProcessState.Выполняется && p2.processState == ProcessState.Выполнен) return -1;
            if (p2.processState == ProcessState.Выполняется && p1.processState == ProcessState.Выполнен) return 1;

            if (p1.processState == ProcessState.В_очереди && p2.processState == ProcessState.Заблокирован) return -1;
            if (p2.processState == ProcessState.В_очереди && p1.processState == ProcessState.Заблокирован) return 1;
            if (p1.processState == ProcessState.В_очереди && p2.processState == ProcessState.Выполнен) return -1;
            if (p2.processState == ProcessState.В_очереди && p1.processState == ProcessState.Выполнен) return 1;

            if (p1.processState == ProcessState.Заблокирован && p2.processState == ProcessState.Выполнен) return -1;
            if (p2.processState == ProcessState.Заблокирован && p1.processState == ProcessState.Выполнен) return 1;

            return 0;
        }
    }
}
