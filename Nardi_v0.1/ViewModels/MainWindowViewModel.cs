using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nardi_v0._1.ViewModels.Base
{
    internal class MainWindowViewModel : ViewModel

    {
        #region WindowTitle

        private string _Title = "Нарды v0.1";
        /// <summary> WindowTitle </summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion
    }

}
