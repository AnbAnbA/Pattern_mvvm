using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Pattern_mvvm
{
    internal class ViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public List<string> CombCH 
        {
            get 
            {
                return Model.dataList;
            }
        }
        int cbInd = -1;
        public int IS 
        {
            set 
            {
                cbInd = value;
                PropertyChanged(this, new PropertyChangedEventArgs("CbIndex"));
            }
        }
        public string CbIndex 
        {
            get 
            {
                if (cbInd == -1)
                {
                    return "";
                }
                else if(cbInd==0)
                {
                    return "+";
                }
                else if (cbInd == 1)
                {
                    return "-";
                }
                else if (cbInd == 2)
                {
                    return "*";
                }
                else if (cbInd == 3)
                {
                    return "/";
                }
                else
                {
                    return "";
                }
            }
        }

        public double one 
        {
            set 
            {
                Model.a = value;
            }
        }

        public double two
        {
            set
            {
                Model.b = value;
            }
        }


        public string ResChange 
        {
            get 
            {
                return Model.res.ToString();
            }
        }
        public CommandBinding bind;
        public RoutedCommand command { get; set; }=new RoutedCommand();
        public void Command_Executed(object sender, ExecutedRoutedEventArgs e) 
        {
            if (cbInd == -1)
            {
                Model.res = Convert.ToDouble(null);
            }
            else if (cbInd == 0)
            {
                Model.res = Model.a + Model.b;
            }
            else if (cbInd == 1)
            {
                Model.res = Model.a - Model.b;
            }
            else if (cbInd == 2)
            {
                Model.res = Model.a * Model.b;
            }
            else if (cbInd == 3)
            {
                Model.res = Model.a / Model.b; 
            }
            else
            {
               Model.res = Convert.ToDouble(null);
            }
            PropertyChanged(this, new PropertyChangedEventArgs("ResChange"));
        }
        public ViewModel() 
        {
            bind = new CommandBinding(command);
            bind.Executed += Command_Executed;
        }
    }
}
