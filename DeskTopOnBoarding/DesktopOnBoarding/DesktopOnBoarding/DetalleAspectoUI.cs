using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010;
using DevExpress.Utils.VisualEffects;
using DevExpress.XtraSplashScreen;
 
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;


namespace DesktopOnBoarding
{
    public partial class DetalleAspectoUI : DevExpress.XtraEditors.XtraForm
    {
        public DetalleAspectoUI()
        {
            InitializeComponent();
        }

       
        /// <summary>
        /// Procedimiento que carga todos los maestros necesarios para que el formulario funcioné, podrá ser llamado en el evento OnLoad de la forma
        /// </summary>
        private async Task CargaInicial()
        {
            try
            {
                EstadoControlesEnPantalla(false);
                await CargaInformacionAspectoTecnico();
                await CargaInformacionAspectoConductual();
                await CargaInformacionEmpleado();
                await CargarInformacionDeDetalleAspecto();
                ButtonNuevo.Enabled = true;
            }
            catch (Exception ex)
            {
              

            }
            finally
            {
               
            }

        }
        /// <summary>
        /// Maneja el estado  los controles en pantalla
        /// </summary>
        /// <param name="valor"></param>
        private void EstadoControlesEnPantalla(bool valor)
        {

            HabilitaDeshabilitaControles(valor);

        }

        /// <summary>
        /// Procedimiento que habilita/deshabilita los componentes que permiten ingreso de información por parte del usuario
        /// </summary>
        private void HabilitaDeshabilitaControles(bool valor)
        {
            try
            {
                // Aqui irán todos los componentes que deberán ser mostrados en el formulario
                
                txtCodigoDetalle.Enabled = false;
               
                lookUpEditCodigoEmpleado.Enabled = valor;
    
                lookUpEditCodigoAspectoConductual.Enabled = valor;
                lookUpEditCodigoAspectoTecnico.Enabled = valor;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Procedimiento que carga información del detalle de aspectos(tecnico y conceptual) relacionados
        /// </summary>
        private async Task CargarInformacionDeDetalleAspecto()
        {
            try
            {
                List<DetalleAspectosBE> lista = null;
                DetalleAspectoBLL datos = new DetalleAspectoBLL();
                lista = await datos.Listar();

                gridDetalleAspecto.DataSource = null;
                gridDetalleAspecto.DataSource = lista;

            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Procedimiento que carga información de aspectos TEcnico
        /// </summary>
        /// <returns></returns>
        private async Task CargaInformacionAspectoTecnico()
        {

            try
            {
                List<AspectoTecnicoBE> lista = null;
                AspectoTecnicoBLL datos = new AspectoTecnicoBLL();
                lista = await datos.Listar();

                lookUpEditCodigoAspectoTecnico.Properties.DataSource = null;
                lookUpEditCodigoAspectoTecnico.Properties.DataSource = lista;
                lookUpEditCodigoAspectoTecnico.Properties.DisplayMember = "NombreAspectoTecnico";
                lookUpEditCodigoAspectoTecnico.Properties.ValueMember = "CodigoAspectoTecnico";
                lookUpEditCodigoAspectoTecnico.Properties.NullText = "Seleccione un aspecto tecnico";

                // Esto es opcional, pero en caso queramos setear las columnas y los textos que aparecerán será mejor hacerlo asi
                lookUpEditCodigoAspectoTecnico.Properties.Columns.Clear();
                lookUpEditCodigoAspectoTecnico.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
                {
                    new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoAspectoTecnico", "Código"),
                    new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreAspectoTecnico", "Nombre"),
                  
                 });



            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Procedimiento que carga información de aspectos conductuales
        /// </summary>
        /// <returns></returns>
        private async Task CargaInformacionAspectoConductual()
        {

            try
            {
                List<AspectosConductualesBE> lista = null;
                AspectoConductualBLL datos = new AspectoConductualBLL();
                lista = await datos.Listar();

                lookUpEditCodigoAspectoConductual.Properties.DataSource = null;
                lookUpEditCodigoAspectoConductual.Properties.DataSource = lista;
                lookUpEditCodigoAspectoConductual.Properties.DisplayMember = "NombreWill";
                lookUpEditCodigoAspectoConductual.Properties.ValueMember = "CodigoWill";
                lookUpEditCodigoAspectoConductual.Properties.NullText = "Seleccione un aspecto conductual";

                // Esto es opcional, pero en caso queramos setear las columnas y los textos que aparecerán será mejor hacerlo asi
                lookUpEditCodigoAspectoConductual.Properties.Columns.Clear();
                lookUpEditCodigoAspectoConductual.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
                {
                    new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoWill", "Código"),
                    new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreWill", "Nombre"),
                    new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripción")
                 });



            }
            catch (Exception ex)
            {

            }
        }


        /// <summary>
        /// Procedimiento que carga información de la Empleado
        /// </summary>
        /// <returns></returns>
        private async Task CargaInformacionEmpleado()
        {

            try
            {
                List<EmpleadoBE> lista = null;
               EmpleadoBLL datos = new EmpleadoBLL();
                lista = await datos.Listar();

                lookUpEditCodigoEmpleado.Properties.DataSource = null;
                lookUpEditCodigoEmpleado.Properties.DataSource = lista;
                lookUpEditCodigoEmpleado.Properties.DisplayMember = "NombreEmpleado";
                lookUpEditCodigoEmpleado.Properties.ValueMember = "CodigoEmpleado";
                lookUpEditCodigoEmpleado.Properties.NullText = "Seleccione un empleado";

                // Esto es opcional, pero en caso queramos setear las columnas y los textos que aparecerán será mejor hacerlo asi
                lookUpEditCodigoEmpleado.Properties.Columns.Clear();
                lookUpEditCodigoEmpleado.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
                {
                    new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoEmpleado", "Código"),
                    new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreEmpleado", "Empresa")
                 });



            }
            catch (Exception ex)
            {

            }
        }

        private void ButtonNuevo_Click(object sender, EventArgs e)
        {
            ButtonGuardar.Enabled = true;
            lookUpEditCodigoEmpleado.Enabled = true;
            lookUpEditCodigoAspectoConductual.Enabled = true;
            lookUpEditCodigoAspectoTecnico.Enabled = true;

        }

        /// <summary>
        /// Evento Load de la forma principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void DetalleAspectoUI_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            // Esto hace que se pueda cerrar la forma aun aunque no este validado todo
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            this.CausesValidation = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            //Bloquear control box            
            this.CloseBox = false;
            //Cargar Maestros
            await CargaInicial();
            //Desbloquear control box
            this.CloseBox = true;
        }
    }
}
