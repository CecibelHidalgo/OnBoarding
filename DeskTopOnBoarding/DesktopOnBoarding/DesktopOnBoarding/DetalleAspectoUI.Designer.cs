namespace DesktopOnBoarding
{
    partial class DetalleAspectoUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gcInformacionGeneral = new DevExpress.XtraEditors.GroupControl();
            this.ButtonEditar = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEditCodigoEmpleado = new DevExpress.XtraEditors.LookUpEdit();
            this.txtCodigoDetalle = new DevExpress.XtraEditors.TextEdit();
            this.lbCodigoRecurso = new DevExpress.XtraEditors.LabelControl();
            this.lbEmpleado = new DevExpress.XtraEditors.LabelControl();
            this.gcDetalle = new DevExpress.XtraEditors.GroupControl();
            this.gridDetalleAspecto = new DevExpress.XtraGrid.GridControl();
            this.gridViewDetalleAspecto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColNombreArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColCodigoEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColNombreEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpEditCodigoAspectoTecnico = new DevExpress.XtraEditors.LookUpEdit();
            this.lbCodigoAspecto = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditCodigoAspectoConductual = new DevExpress.XtraEditors.LookUpEdit();
            this.lbAspectoConductual = new DevExpress.XtraEditors.LabelControl();
            this.gridColNombrePuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColNombreAspectoTecnico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColNombreActividad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColNombreWill = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColPeso = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcInformacionGeneral)).BeginInit();
            this.gcInformacionGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCodigoEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoDetalle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalle)).BeginInit();
            this.gcDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleAspecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalleAspecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCodigoAspectoTecnico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCodigoAspectoConductual.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcInformacionGeneral
            // 
            this.gcInformacionGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcInformacionGeneral.Controls.Add(this.lookUpEditCodigoAspectoConductual);
            this.gcInformacionGeneral.Controls.Add(this.lbAspectoConductual);
            this.gcInformacionGeneral.Controls.Add(this.lookUpEditCodigoAspectoTecnico);
            this.gcInformacionGeneral.Controls.Add(this.lbCodigoAspecto);
            this.gcInformacionGeneral.Controls.Add(this.ButtonEditar);
            this.gcInformacionGeneral.Controls.Add(this.ButtonNuevo);
            this.gcInformacionGeneral.Controls.Add(this.ButtonGuardar);
            this.gcInformacionGeneral.Controls.Add(this.lookUpEditCodigoEmpleado);
            this.gcInformacionGeneral.Controls.Add(this.txtCodigoDetalle);
            this.gcInformacionGeneral.Controls.Add(this.lbCodigoRecurso);
            this.gcInformacionGeneral.Controls.Add(this.lbEmpleado);
            this.gcInformacionGeneral.Location = new System.Drawing.Point(12, 12);
            this.gcInformacionGeneral.Name = "gcInformacionGeneral";
            this.gcInformacionGeneral.Size = new System.Drawing.Size(852, 137);
            this.gcInformacionGeneral.TabIndex = 14;
            this.gcInformacionGeneral.Text = "Información general";
            // 
            // ButtonEditar
            // 
            this.ButtonEditar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ButtonEditar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEditar.Appearance.ForeColor = System.Drawing.Color.White;
            this.ButtonEditar.Appearance.Options.UseBackColor = true;
            this.ButtonEditar.Appearance.Options.UseFont = true;
            this.ButtonEditar.Appearance.Options.UseForeColor = true;
            this.ButtonEditar.AutoWidthInLayoutControl = true;
            this.ButtonEditar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.ButtonEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEditar.Enabled = false;
            this.ButtonEditar.Location = new System.Drawing.Point(730, 56);
            this.ButtonEditar.Name = "ButtonEditar";
            this.ButtonEditar.Size = new System.Drawing.Size(98, 25);
            this.ButtonEditar.TabIndex = 11;
            this.ButtonEditar.Text = "Editar";
            // 
            // ButtonNuevo
            // 
            this.ButtonNuevo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ButtonNuevo.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNuevo.Appearance.ForeColor = System.Drawing.Color.White;
            this.ButtonNuevo.Appearance.Options.UseBackColor = true;
            this.ButtonNuevo.Appearance.Options.UseFont = true;
            this.ButtonNuevo.Appearance.Options.UseForeColor = true;
            this.ButtonNuevo.AutoWidthInLayoutControl = true;
            this.ButtonNuevo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.ButtonNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNuevo.Enabled = false;
            this.ButtonNuevo.Location = new System.Drawing.Point(730, 25);
            this.ButtonNuevo.Name = "ButtonNuevo";
            this.ButtonNuevo.Size = new System.Drawing.Size(98, 25);
            this.ButtonNuevo.TabIndex = 10;
            this.ButtonNuevo.Text = "Nuevo";
            this.ButtonNuevo.Click += new System.EventHandler(this.ButtonNuevo_Click);
            // 
            // ButtonGuardar
            // 
            this.ButtonGuardar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ButtonGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGuardar.Appearance.ForeColor = System.Drawing.Color.White;
            this.ButtonGuardar.Appearance.Options.UseBackColor = true;
            this.ButtonGuardar.Appearance.Options.UseFont = true;
            this.ButtonGuardar.Appearance.Options.UseForeColor = true;
            this.ButtonGuardar.AutoWidthInLayoutControl = true;
            this.ButtonGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.ButtonGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonGuardar.Enabled = false;
            this.ButtonGuardar.Location = new System.Drawing.Point(730, 87);
            this.ButtonGuardar.Name = "ButtonGuardar";
            this.ButtonGuardar.Size = new System.Drawing.Size(98, 25);
            this.ButtonGuardar.TabIndex = 9;
            this.ButtonGuardar.Text = "Guardar";
            // 
            // lookUpEditCodigoEmpleado
            // 
            this.lookUpEditCodigoEmpleado.Location = new System.Drawing.Point(196, 44);
            this.lookUpEditCodigoEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.lookUpEditCodigoEmpleado.Name = "lookUpEditCodigoEmpleado";
            this.lookUpEditCodigoEmpleado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCodigoEmpleado.Size = new System.Drawing.Size(275, 20);
            this.lookUpEditCodigoEmpleado.TabIndex = 6;
            // 
            // txtCodigoDetalle
            // 
            this.txtCodigoDetalle.Enabled = false;
            this.txtCodigoDetalle.Location = new System.Drawing.Point(11, 44);
            this.txtCodigoDetalle.Name = "txtCodigoDetalle";
            this.txtCodigoDetalle.Size = new System.Drawing.Size(144, 20);
            this.txtCodigoDetalle.TabIndex = 0;
            // 
            // lbCodigoRecurso
            // 
            this.lbCodigoRecurso.Location = new System.Drawing.Point(11, 24);
            this.lbCodigoRecurso.Name = "lbCodigoRecurso";
            this.lbCodigoRecurso.Size = new System.Drawing.Size(69, 13);
            this.lbCodigoRecurso.TabIndex = 1;
            this.lbCodigoRecurso.Text = "Código Detalle";
            // 
            // lbEmpleado
            // 
            this.lbEmpleado.Location = new System.Drawing.Point(196, 26);
            this.lbEmpleado.Name = "lbEmpleado";
            this.lbEmpleado.Size = new System.Drawing.Size(82, 13);
            this.lbEmpleado.TabIndex = 2;
            this.lbEmpleado.Text = "Código Empleado";
            // 
            // gcDetalle
            // 
            this.gcDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDetalle.Controls.Add(this.gridDetalleAspecto);
            this.gcDetalle.Location = new System.Drawing.Point(12, 155);
            this.gcDetalle.Name = "gcDetalle";
            this.gcDetalle.Padding = new System.Windows.Forms.Padding(7);
            this.gcDetalle.Size = new System.Drawing.Size(847, 332);
            this.gcDetalle.TabIndex = 15;
            this.gcDetalle.Text = "Detalle";
            // 
            // gridDetalleAspecto
            // 
            this.gridDetalleAspecto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDetalleAspecto.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridDetalleAspecto.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridDetalleAspecto.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridDetalleAspecto.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridDetalleAspecto.EmbeddedNavigator.Buttons.First.Visible = false;
            this.gridDetalleAspecto.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.gridDetalleAspecto.EmbeddedNavigator.Buttons.Next.Visible = false;
            this.gridDetalleAspecto.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gridDetalleAspecto.EmbeddedNavigator.Buttons.Prev.Visible = false;
            this.gridDetalleAspecto.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.gridDetalleAspecto.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridDetalleAspecto.EmbeddedNavigator.TextStringFormat = "Registro {0} of {1}";
            this.gridDetalleAspecto.Location = new System.Drawing.Point(9, 27);
            this.gridDetalleAspecto.MainView = this.gridViewDetalleAspecto;
            this.gridDetalleAspecto.Margin = new System.Windows.Forms.Padding(0);
            this.gridDetalleAspecto.Name = "gridDetalleAspecto";
            this.gridDetalleAspecto.Size = new System.Drawing.Size(829, 296);
            this.gridDetalleAspecto.TabIndex = 14;
            this.gridDetalleAspecto.UseEmbeddedNavigator = true;
            this.gridDetalleAspecto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDetalleAspecto});
            // 
            // gridViewDetalleAspecto
            // 
            this.gridViewDetalleAspecto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColCodigoEmpleado,
            this.gridColNombreEmpleado,
            this.gridColNombreArea,
            this.gridColNombrePuesto,
            this.gridColNombreAspectoTecnico,
            this.gridColNombreActividad,
            this.gridColNombreWill,
            this.gridColDescripcion,
            this.gridColPeso});
            this.gridViewDetalleAspecto.GridControl = this.gridDetalleAspecto;
            this.gridViewDetalleAspecto.Name = "gridViewDetalleAspecto";
            this.gridViewDetalleAspecto.OptionsView.ColumnAutoWidth = false;
            this.gridViewDetalleAspecto.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDetalleAspecto.OptionsView.ShowGroupPanel = false;
            // 
            // gridColNombreArea
            // 
            this.gridColNombreArea.Caption = "Área";
            this.gridColNombreArea.FieldName = "NombreArea";
            this.gridColNombreArea.Name = "gridColNombreArea";
            this.gridColNombreArea.OptionsColumn.AllowEdit = false;
            this.gridColNombreArea.Visible = true;
            this.gridColNombreArea.VisibleIndex = 2;
            this.gridColNombreArea.Width = 217;
            // 
            // gridColCodigoEmpleado
            // 
            this.gridColCodigoEmpleado.Caption = "Código Empleado";
            this.gridColCodigoEmpleado.FieldName = "CodigoEmpleado";
            this.gridColCodigoEmpleado.Name = "gridColCodigoEmpleado";
            this.gridColCodigoEmpleado.OptionsColumn.AllowEdit = false;
            this.gridColCodigoEmpleado.Visible = true;
            this.gridColCodigoEmpleado.VisibleIndex = 0;
            this.gridColCodigoEmpleado.Width = 100;
            // 
            // gridColNombreEmpleado
            // 
            this.gridColNombreEmpleado.Caption = "Nombre Empleado";
            this.gridColNombreEmpleado.FieldName = "NombreEmpleado";
            this.gridColNombreEmpleado.Name = "gridColNombreEmpleado";
            this.gridColNombreEmpleado.Visible = true;
            this.gridColNombreEmpleado.VisibleIndex = 1;
            this.gridColNombreEmpleado.Width = 221;
            // 
            // lookUpEditCodigoAspectoTecnico
            // 
            this.lookUpEditCodigoAspectoTecnico.Location = new System.Drawing.Point(11, 90);
            this.lookUpEditCodigoAspectoTecnico.Margin = new System.Windows.Forms.Padding(2);
            this.lookUpEditCodigoAspectoTecnico.Name = "lookUpEditCodigoAspectoTecnico";
            this.lookUpEditCodigoAspectoTecnico.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCodigoAspectoTecnico.Size = new System.Drawing.Size(250, 20);
            this.lookUpEditCodigoAspectoTecnico.TabIndex = 13;
            // 
            // lbCodigoAspecto
            // 
            this.lbCodigoAspecto.Location = new System.Drawing.Point(11, 72);
            this.lbCodigoAspecto.Name = "lbCodigoAspecto";
            this.lbCodigoAspecto.Size = new System.Drawing.Size(78, 13);
            this.lbCodigoAspecto.TabIndex = 12;
            this.lbCodigoAspecto.Text = "Aspecto Técnico";
            // 
            // lookUpEditCodigoAspectoConductual
            // 
            this.lookUpEditCodigoAspectoConductual.Location = new System.Drawing.Point(299, 90);
            this.lookUpEditCodigoAspectoConductual.Margin = new System.Windows.Forms.Padding(2);
            this.lookUpEditCodigoAspectoConductual.Name = "lookUpEditCodigoAspectoConductual";
            this.lookUpEditCodigoAspectoConductual.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCodigoAspectoConductual.Size = new System.Drawing.Size(256, 20);
            this.lookUpEditCodigoAspectoConductual.TabIndex = 15;
            // 
            // lbAspectoConductual
            // 
            this.lbAspectoConductual.Location = new System.Drawing.Point(299, 72);
            this.lbAspectoConductual.Name = "lbAspectoConductual";
            this.lbAspectoConductual.Size = new System.Drawing.Size(96, 13);
            this.lbAspectoConductual.TabIndex = 14;
            this.lbAspectoConductual.Text = "Aspecto Conductual";
            // 
            // gridColNombrePuesto
            // 
            this.gridColNombrePuesto.Caption = "Nombre Puesto";
            this.gridColNombrePuesto.FieldName = "NombrePuesto";
            this.gridColNombrePuesto.Name = "gridColNombrePuesto";
            this.gridColNombrePuesto.OptionsColumn.AllowEdit = false;
            this.gridColNombrePuesto.Visible = true;
            this.gridColNombrePuesto.VisibleIndex = 3;
            this.gridColNombrePuesto.Width = 150;
            // 
            // gridColNombreAspectoTecnico
            // 
            this.gridColNombreAspectoTecnico.Caption = "Aspecto Técnico";
            this.gridColNombreAspectoTecnico.FieldName = "NombreAspectoTecnico";
            this.gridColNombreAspectoTecnico.Name = "gridColNombreAspectoTecnico";
            this.gridColNombreAspectoTecnico.OptionsColumn.AllowEdit = false;
            this.gridColNombreAspectoTecnico.Visible = true;
            this.gridColNombreAspectoTecnico.VisibleIndex = 4;
            this.gridColNombreAspectoTecnico.Width = 150;
            // 
            // gridColNombreActividad
            // 
            this.gridColNombreActividad.Caption = "Nombre Actividad";
            this.gridColNombreActividad.FieldName = "NombreActividad";
            this.gridColNombreActividad.Name = "gridColNombreActividad";
            this.gridColNombreActividad.OptionsColumn.AllowEdit = false;
            this.gridColNombreActividad.Visible = true;
            this.gridColNombreActividad.VisibleIndex = 5;
            this.gridColNombreActividad.Width = 150;
            // 
            // gridColNombreWill
            // 
            this.gridColNombreWill.Caption = "Aspecto Conductual";
            this.gridColNombreWill.FieldName = "NombreWill";
            this.gridColNombreWill.Name = "gridColNombreWill";
            this.gridColNombreWill.OptionsColumn.AllowEdit = false;
            this.gridColNombreWill.Visible = true;
            this.gridColNombreWill.VisibleIndex = 6;
            this.gridColNombreWill.Width = 150;
            // 
            // gridColDescripcion
            // 
            this.gridColDescripcion.Caption = "Descripción";
            this.gridColDescripcion.FieldName = "Descripcion";
            this.gridColDescripcion.Name = "gridColDescripcion";
            this.gridColDescripcion.OptionsColumn.AllowEdit = false;
            this.gridColDescripcion.Visible = true;
            this.gridColDescripcion.VisibleIndex = 7;
            this.gridColDescripcion.Width = 150;
            // 
            // gridColPeso
            // 
            this.gridColPeso.Caption = "Peso";
            this.gridColPeso.FieldName = "Peso";
            this.gridColPeso.Name = "gridColPeso";
            this.gridColPeso.OptionsColumn.AllowEdit = false;
            this.gridColPeso.Visible = true;
            this.gridColPeso.VisibleIndex = 8;
            // 
            // DetalleAspectoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 490);
            this.Controls.Add(this.gcDetalle);
            this.Controls.Add(this.gcInformacionGeneral);
            this.Name = "DetalleAspectoUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Aspectos";
            this.Load += new System.EventHandler(this.DetalleAspectoUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcInformacionGeneral)).EndInit();
            this.gcInformacionGeneral.ResumeLayout(false);
            this.gcInformacionGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCodigoEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoDetalle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalle)).EndInit();
            this.gcDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleAspecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalleAspecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCodigoAspectoTecnico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCodigoAspectoConductual.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcInformacionGeneral;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCodigoEmpleado;
        private DevExpress.XtraEditors.TextEdit txtCodigoDetalle;
        private DevExpress.XtraEditors.LabelControl lbCodigoRecurso;
        private DevExpress.XtraEditors.LabelControl lbEmpleado;
        private DevExpress.XtraEditors.GroupControl gcDetalle;
        private DevExpress.XtraGrid.GridControl gridDetalleAspecto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetalleAspecto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColNombreArea;
        private DevExpress.XtraGrid.Columns.GridColumn gridColCodigoEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn gridColNombreEmpleado;
        private DevExpress.XtraEditors.SimpleButton ButtonGuardar;
        private DevExpress.XtraEditors.SimpleButton ButtonEditar;
        private DevExpress.XtraEditors.SimpleButton ButtonNuevo;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCodigoAspectoConductual;
        private DevExpress.XtraEditors.LabelControl lbAspectoConductual;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCodigoAspectoTecnico;
        private DevExpress.XtraEditors.LabelControl lbCodigoAspecto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColNombrePuesto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColNombreAspectoTecnico;
        private DevExpress.XtraGrid.Columns.GridColumn gridColNombreActividad;
        private DevExpress.XtraGrid.Columns.GridColumn gridColNombreWill;
        private DevExpress.XtraGrid.Columns.GridColumn gridColDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColPeso;
    }
}

