namespace DesktopOnBoarding
{
    partial class RecursosUI
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
            this.txtNombreRecurso = new DevExpress.XtraEditors.TextEdit();
            this.lbNombreRecurso = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditCodigoEmpleado = new DevExpress.XtraEditors.LookUpEdit();
            this.txtCodigoRecurso = new DevExpress.XtraEditors.TextEdit();
            this.lbCodigoRecurso = new DevExpress.XtraEditors.LabelControl();
            this.lbEmpleado = new DevExpress.XtraEditors.LabelControl();
            this.gcDetalle = new DevExpress.XtraEditors.GroupControl();
            this.gridRecurso = new DevExpress.XtraGrid.GridControl();
            this.gridViewRecurso = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColCodigoRecurso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColNombreRecurso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColCodigoEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColNombreEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcInformacionGeneral)).BeginInit();
            this.gcInformacionGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreRecurso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCodigoEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoRecurso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalle)).BeginInit();
            this.gcDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRecurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRecurso)).BeginInit();
            this.SuspendLayout();
            // 
            // gcInformacionGeneral
            // 
            this.gcInformacionGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcInformacionGeneral.Controls.Add(this.ButtonEditar);
            this.gcInformacionGeneral.Controls.Add(this.ButtonNuevo);
            this.gcInformacionGeneral.Controls.Add(this.ButtonGuardar);
            this.gcInformacionGeneral.Controls.Add(this.txtNombreRecurso);
            this.gcInformacionGeneral.Controls.Add(this.lbNombreRecurso);
            this.gcInformacionGeneral.Controls.Add(this.lookUpEditCodigoEmpleado);
            this.gcInformacionGeneral.Controls.Add(this.txtCodigoRecurso);
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
            // txtNombreRecurso
            // 
            this.txtNombreRecurso.EditValue = " ";
            this.txtNombreRecurso.Enabled = false;
            this.txtNombreRecurso.EnterMoveNextControl = true;
            this.txtNombreRecurso.Location = new System.Drawing.Point(318, 44);
            this.txtNombreRecurso.Name = "txtNombreRecurso";
            this.txtNombreRecurso.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNombreRecurso.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtNombreRecurso.Size = new System.Drawing.Size(275, 20);
            this.txtNombreRecurso.TabIndex = 8;
            // 
            // lbNombreRecurso
            // 
            this.lbNombreRecurso.Location = new System.Drawing.Point(318, 25);
            this.lbNombreRecurso.Name = "lbNombreRecurso";
            this.lbNombreRecurso.Size = new System.Drawing.Size(79, 13);
            this.lbNombreRecurso.TabIndex = 7;
            this.lbNombreRecurso.Text = "Nombre Recurso";
            // 
            // lookUpEditCodigoEmpleado
            // 
            this.lookUpEditCodigoEmpleado.Location = new System.Drawing.Point(11, 104);
            this.lookUpEditCodigoEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.lookUpEditCodigoEmpleado.Name = "lookUpEditCodigoEmpleado";
            this.lookUpEditCodigoEmpleado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCodigoEmpleado.Size = new System.Drawing.Size(275, 20);
            this.lookUpEditCodigoEmpleado.TabIndex = 6;
            // 
            // txtCodigoRecurso
            // 
            this.txtCodigoRecurso.Enabled = false;
            this.txtCodigoRecurso.Location = new System.Drawing.Point(11, 44);
            this.txtCodigoRecurso.Name = "txtCodigoRecurso";
            this.txtCodigoRecurso.Size = new System.Drawing.Size(275, 20);
            this.txtCodigoRecurso.TabIndex = 0;
            // 
            // lbCodigoRecurso
            // 
            this.lbCodigoRecurso.Location = new System.Drawing.Point(11, 24);
            this.lbCodigoRecurso.Name = "lbCodigoRecurso";
            this.lbCodigoRecurso.Size = new System.Drawing.Size(75, 13);
            this.lbCodigoRecurso.TabIndex = 1;
            this.lbCodigoRecurso.Text = "Código Recurso";
            // 
            // lbEmpleado
            // 
            this.lbEmpleado.Location = new System.Drawing.Point(11, 86);
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
            this.gcDetalle.Controls.Add(this.gridRecurso);
            this.gcDetalle.Location = new System.Drawing.Point(12, 155);
            this.gcDetalle.Name = "gcDetalle";
            this.gcDetalle.Padding = new System.Windows.Forms.Padding(7);
            this.gcDetalle.Size = new System.Drawing.Size(847, 332);
            this.gcDetalle.TabIndex = 15;
            this.gcDetalle.Text = "Detalle";
            // 
            // gridRecurso
            // 
            this.gridRecurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRecurso.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridRecurso.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridRecurso.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridRecurso.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridRecurso.EmbeddedNavigator.Buttons.First.Visible = false;
            this.gridRecurso.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.gridRecurso.EmbeddedNavigator.Buttons.Next.Visible = false;
            this.gridRecurso.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gridRecurso.EmbeddedNavigator.Buttons.Prev.Visible = false;
            this.gridRecurso.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.gridRecurso.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridRecurso.EmbeddedNavigator.TextStringFormat = "Registro {0} of {1}";
            this.gridRecurso.Location = new System.Drawing.Point(9, 27);
            this.gridRecurso.MainView = this.gridViewRecurso;
            this.gridRecurso.Margin = new System.Windows.Forms.Padding(0);
            this.gridRecurso.Name = "gridRecurso";
            this.gridRecurso.Size = new System.Drawing.Size(829, 296);
            this.gridRecurso.TabIndex = 14;
            this.gridRecurso.UseEmbeddedNavigator = true;
            this.gridRecurso.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRecurso});
            // 
            // gridViewRecurso
            // 
            this.gridViewRecurso.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColCodigoRecurso,
            this.gridColNombreRecurso,
            this.gridColCodigoEmpleado,
            this.gridColNombreEmpleado});
            this.gridViewRecurso.GridControl = this.gridRecurso;
            this.gridViewRecurso.Name = "gridViewRecurso";
            this.gridViewRecurso.OptionsView.ShowAutoFilterRow = true;
            this.gridViewRecurso.OptionsView.ShowGroupPanel = false;
            // 
            // gridColCodigoRecurso
            // 
            this.gridColCodigoRecurso.Caption = "Código Recurso";
            this.gridColCodigoRecurso.FieldName = "CodigoRecurso";
            this.gridColCodigoRecurso.Name = "gridColCodigoRecurso";
            this.gridColCodigoRecurso.Visible = true;
            this.gridColCodigoRecurso.VisibleIndex = 0;
            // 
            // gridColNombreRecurso
            // 
            this.gridColNombreRecurso.Caption = "Nombre Recurso";
            this.gridColNombreRecurso.FieldName = "NombreRecurso";
            this.gridColNombreRecurso.Name = "gridColNombreRecurso";
            this.gridColNombreRecurso.OptionsColumn.AllowEdit = false;
            this.gridColNombreRecurso.Visible = true;
            this.gridColNombreRecurso.VisibleIndex = 1;
            // 
            // gridColCodigoEmpleado
            // 
            this.gridColCodigoEmpleado.Caption = "Código Empleado";
            this.gridColCodigoEmpleado.FieldName = "CodigoEmpleado";
            this.gridColCodigoEmpleado.Name = "gridColCodigoEmpleado";
            this.gridColCodigoEmpleado.OptionsColumn.AllowEdit = false;
            this.gridColCodigoEmpleado.Visible = true;
            this.gridColCodigoEmpleado.VisibleIndex = 2;
            // 
            // gridColNombreEmpleado
            // 
            this.gridColNombreEmpleado.Caption = "Nombre Empleado";
            this.gridColNombreEmpleado.FieldName = "NombreEmpleado";
            this.gridColNombreEmpleado.Name = "gridColNombreEmpleado";
            this.gridColNombreEmpleado.Visible = true;
            this.gridColNombreEmpleado.VisibleIndex = 3;
            // 
            // RecursosUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 490);
            this.Controls.Add(this.gcDetalle);
            this.Controls.Add(this.gcInformacionGeneral);
            this.Name = "RecursosUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recursos";
            this.Load += new System.EventHandler(this.RecursosUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcInformacionGeneral)).EndInit();
            this.gcInformacionGeneral.ResumeLayout(false);
            this.gcInformacionGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreRecurso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCodigoEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoRecurso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalle)).EndInit();
            this.gcDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRecurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRecurso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcInformacionGeneral;
        private DevExpress.XtraEditors.TextEdit txtNombreRecurso;
        private DevExpress.XtraEditors.LabelControl lbNombreRecurso;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCodigoEmpleado;
        private DevExpress.XtraEditors.TextEdit txtCodigoRecurso;
        private DevExpress.XtraEditors.LabelControl lbCodigoRecurso;
        private DevExpress.XtraEditors.LabelControl lbEmpleado;
        private DevExpress.XtraEditors.GroupControl gcDetalle;
        private DevExpress.XtraGrid.GridControl gridRecurso;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRecurso;
        private DevExpress.XtraGrid.Columns.GridColumn gridColCodigoRecurso;
        private DevExpress.XtraGrid.Columns.GridColumn gridColNombreRecurso;
        private DevExpress.XtraGrid.Columns.GridColumn gridColCodigoEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn gridColNombreEmpleado;
        private DevExpress.XtraEditors.SimpleButton ButtonGuardar;
        private DevExpress.XtraEditors.SimpleButton ButtonEditar;
        private DevExpress.XtraEditors.SimpleButton ButtonNuevo;
    }
}

