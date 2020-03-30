using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetGamer.Models
{
    public class Configuration
    {
        /// <summary>
        /// The ID(in DB) of the selected Processor
        /// </summary>
        private int cpuID;
        /// <summary>
        /// The ID(in DB) of the selected Graphics Card
        /// </summary>
        private int gpuID;
        /// <summary>
        /// The ID(in DB) of the selected Motherboard
        /// </summary>
        private int mbID;
        /// <summary>
        /// The ID(in DB) of the selected Case
        /// </summary>
        private int caseID;


        public Configuration()
        {
            
        }
    }
}