using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Interfaces
{
    public interface IApplication
    {
         string appName { get; set; }
         string appDesp { get; set; }
         int appId { get; set; }
         int isDeleted { get; set; }
         int status { get; set; }
         int skipRows { get; set; }
         int topRows { get; set; }
    }
}
