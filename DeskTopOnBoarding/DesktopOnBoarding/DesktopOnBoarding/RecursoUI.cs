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
    public partial class RecursosUI : DevExpress.XtraEditors.XtraForm
    {
        public RecursosUI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento Load de la forma principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void RecursosUI_Load(object sender, EventArgs e)
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

        /// <summary>
        /// Procedimiento que carga todos los maestros necesarios para que el formulario funcioné, podrá ser llamado en el evento OnLoad de la forma
        /// </summary>
        private async Task CargaInicial()
        {
            try
            {
                EstadoControlesEnPantalla(false);
                await CargarInformacionDeRecursos();
                await CargaInformacionEmpleado();
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
                
                txtCodigoRecurso.Enabled = false;
                txtNombreRecurso.Enabled = valor;
                lookUpEditCodigoEmpleado.Enabled = valor;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async Task CargarInformacionDeRecursos()
        {
            try
            {
                List<RecursoBE> lista = null;
                RecursoBLL datos = new RecursoBLL();
                lista = await datos.Listar();

                gridRecurso.DataSource = null;
                gridRecurso.DataSource = lista;
                 
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
            txtNombreRecurso.Enabled = true;
            lookUpEditCodigoEmpleado.Enabled = true;
       
        }
    }
}
