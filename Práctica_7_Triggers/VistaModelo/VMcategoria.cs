using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Práctica_7_Triggers.VistaModelo
{
    public class VMcategoria:BaseViewModel
    {
        #region Variables
        string _Texto;
        ObservableCollection<Mcategorias> _listaCategorias;
        #endregion

        #region CONTRUCTOR 
        public VMcategoria(INavigation navigation)
        {
            navigation = navigation;
            Mostrarcategorias();
        }

        #endregion

        #region OBJETOS
        /// <summary>
        /// 
        /// </summary>
        public ObservableCollection<Mcategorias> ListaCategorias {
            get { return _listaCategorias; }
            set { SetValue(ref _listaCategorias, value); }

        }
        #endregion Procesos
        public async Task ProcesoAsyncrono()
        {

        }
        public void Mostrarcategorias()
        {
            //Al hacer esti estamos jalando toda la data
            ListaCategorias= new ObservableCollection<Mcategorias>(Datos.Dcategorias.Mostrarcategorias());
        }
    
        #region COMANDOS
        public ICommand ProcesoAsyncomand => new Command(async () =>await  ProcesoAsyncrono());
        public ICommand ProcesoSimpcomand => new Command(Mostrarcategorias);
        #endregion


    }
}
