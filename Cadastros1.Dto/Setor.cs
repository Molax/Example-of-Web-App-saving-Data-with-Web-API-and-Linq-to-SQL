using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastros1.Dto
{
    public class Setor
    {
        private int nldSetor;

        public int Id
        {
            get { return nldSetor; }
            set { nldSetor = value; }
        }

        private string sSetor;

        public string Nome
        {
            get { return sSetor; }
            set { sSetor = value; }
        }
        
        
    }
}
