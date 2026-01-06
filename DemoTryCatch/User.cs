using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTryCatch
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public void SePresenter(string message)
        {
            if(message == null)
            {
                throw new ArgumentNullException("User :SePresenter : Le message ne peut pas être null");
            }
        }
    }
}
