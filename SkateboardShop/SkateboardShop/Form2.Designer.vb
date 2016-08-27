<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim Full_NameLabel As System.Windows.Forms.Label
        Dim Home_AddressLabel As System.Windows.Forms.Label
        Dim Postal_CodeLabel As System.Windows.Forms.Label
        Dim Phone_NumberLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Blue_SkateboardLabel As System.Windows.Forms.Label
        Dim Yellow_SkateboardLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim Total_PriceLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.SkateboardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SkateboardShopDataSet = New SkateboardShop.SkateboardShopDataSet()
        Me.Full_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Home_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Postal_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Blue_SkateboardCheckBox = New System.Windows.Forms.CheckBox()
        Me.Yellow_SkateboardCheckBox = New System.Windows.Forms.CheckBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Total_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SkateboardTableAdapter = New SkateboardShop.SkateboardShopDataSetTableAdapters.SkateboardTableAdapter()
        Me.TableAdapterManager = New SkateboardShop.SkateboardShopDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        Full_NameLabel = New System.Windows.Forms.Label()
        Home_AddressLabel = New System.Windows.Forms.Label()
        Postal_CodeLabel = New System.Windows.Forms.Label()
        Phone_NumberLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Blue_SkateboardLabel = New System.Windows.Forms.Label()
        Yellow_SkateboardLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        Total_PriceLabel = New System.Windows.Forms.Label()
        CType(Me.SkateboardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkateboardShopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.ForeColor = System.Drawing.Color.White
        IDLabel.Location = New System.Drawing.Point(19, 195)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(29, 25)
        IDLabel.TabIndex = 105
        IDLabel.Text = "ID:"
        '
        'Full_NameLabel
        '
        Full_NameLabel.AutoSize = True
        Full_NameLabel.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Full_NameLabel.ForeColor = System.Drawing.Color.White
        Full_NameLabel.Location = New System.Drawing.Point(19, 234)
        Full_NameLabel.Name = "Full_NameLabel"
        Full_NameLabel.Size = New System.Drawing.Size(73, 25)
        Full_NameLabel.TabIndex = 108
        Full_NameLabel.Text = "Full Name:"
        '
        'Home_AddressLabel
        '
        Home_AddressLabel.AutoSize = True
        Home_AddressLabel.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Home_AddressLabel.ForeColor = System.Drawing.Color.White
        Home_AddressLabel.Location = New System.Drawing.Point(19, 272)
        Home_AddressLabel.Name = "Home_AddressLabel"
        Home_AddressLabel.Size = New System.Drawing.Size(103, 25)
        Home_AddressLabel.TabIndex = 110
        Home_AddressLabel.Text = "Home Address:"
        '
        'Postal_CodeLabel
        '
        Postal_CodeLabel.AutoSize = True
        Postal_CodeLabel.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Postal_CodeLabel.ForeColor = System.Drawing.Color.White
        Postal_CodeLabel.Location = New System.Drawing.Point(19, 315)
        Postal_CodeLabel.Name = "Postal_CodeLabel"
        Postal_CodeLabel.Size = New System.Drawing.Size(87, 25)
        Postal_CodeLabel.TabIndex = 112
        Postal_CodeLabel.Text = "Postal Code:"
        '
        'Phone_NumberLabel
        '
        Phone_NumberLabel.AutoSize = True
        Phone_NumberLabel.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Phone_NumberLabel.ForeColor = System.Drawing.Color.White
        Phone_NumberLabel.Location = New System.Drawing.Point(19, 362)
        Phone_NumberLabel.Name = "Phone_NumberLabel"
        Phone_NumberLabel.Size = New System.Drawing.Size(104, 25)
        Phone_NumberLabel.TabIndex = 114
        Phone_NumberLabel.Text = "Phone Number:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.ForeColor = System.Drawing.Color.White
        EmailLabel.Location = New System.Drawing.Point(19, 408)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(47, 25)
        EmailLabel.TabIndex = 116
        EmailLabel.Text = "Email:"
        '
        'Blue_SkateboardLabel
        '
        Blue_SkateboardLabel.AutoSize = True
        Blue_SkateboardLabel.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Blue_SkateboardLabel.ForeColor = System.Drawing.Color.White
        Blue_SkateboardLabel.Location = New System.Drawing.Point(20, 116)
        Blue_SkateboardLabel.Name = "Blue_SkateboardLabel"
        Blue_SkateboardLabel.Size = New System.Drawing.Size(82, 20)
        Blue_SkateboardLabel.TabIndex = 118
        Blue_SkateboardLabel.Text = "Blue Skateboard:"
        '
        'Yellow_SkateboardLabel
        '
        Yellow_SkateboardLabel.AutoSize = True
        Yellow_SkateboardLabel.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Yellow_SkateboardLabel.ForeColor = System.Drawing.Color.White
        Yellow_SkateboardLabel.Location = New System.Drawing.Point(20, 139)
        Yellow_SkateboardLabel.Name = "Yellow_SkateboardLabel"
        Yellow_SkateboardLabel.Size = New System.Drawing.Size(96, 20)
        Yellow_SkateboardLabel.TabIndex = 120
        Yellow_SkateboardLabel.Text = "Yellow Skateboard:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QuantityLabel.ForeColor = System.Drawing.Color.White
        QuantityLabel.Location = New System.Drawing.Point(19, 451)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(66, 25)
        QuantityLabel.TabIndex = 122
        QuantityLabel.Text = "Quantity:"
        '
        'Total_PriceLabel
        '
        Total_PriceLabel.AutoSize = True
        Total_PriceLabel.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_PriceLabel.ForeColor = System.Drawing.Color.White
        Total_PriceLabel.Location = New System.Drawing.Point(17, 495)
        Total_PriceLabel.Name = "Total_PriceLabel"
        Total_PriceLabel.Size = New System.Drawing.Size(81, 25)
        Total_PriceLabel.TabIndex = 124
        Total_PriceLabel.Text = "Total Price:"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(358, 187)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 100)
        Me.Button2.TabIndex = 126
        Me.Button2.Text = "Proceed To Checkout"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SkateboardBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(129, 187)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(141, 33)
        Me.IDTextBox.TabIndex = 107
        '
        'SkateboardBindingSource
        '
        Me.SkateboardBindingSource.DataMember = "Skateboard"
        Me.SkateboardBindingSource.DataSource = Me.SkateboardShopDataSet
        '
        'SkateboardShopDataSet
        '
        Me.SkateboardShopDataSet.DataSetName = "SkateboardShopDataSet"
        Me.SkateboardShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Full_NameTextBox
        '
        Me.Full_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SkateboardBindingSource, "Full Name", True))
        Me.Full_NameTextBox.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Full_NameTextBox.Location = New System.Drawing.Point(129, 231)
        Me.Full_NameTextBox.Name = "Full_NameTextBox"
        Me.Full_NameTextBox.Size = New System.Drawing.Size(141, 33)
        Me.Full_NameTextBox.TabIndex = 109
        '
        'Home_AddressTextBox
        '
        Me.Home_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SkateboardBindingSource, "Home Address", True))
        Me.Home_AddressTextBox.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Home_AddressTextBox.Location = New System.Drawing.Point(129, 272)
        Me.Home_AddressTextBox.Name = "Home_AddressTextBox"
        Me.Home_AddressTextBox.Size = New System.Drawing.Size(141, 33)
        Me.Home_AddressTextBox.TabIndex = 111
        '
        'Postal_CodeTextBox
        '
        Me.Postal_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SkateboardBindingSource, "Postal Code", True))
        Me.Postal_CodeTextBox.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Postal_CodeTextBox.Location = New System.Drawing.Point(129, 315)
        Me.Postal_CodeTextBox.Name = "Postal_CodeTextBox"
        Me.Postal_CodeTextBox.Size = New System.Drawing.Size(141, 33)
        Me.Postal_CodeTextBox.TabIndex = 113
        '
        'Phone_NumberTextBox
        '
        Me.Phone_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SkateboardBindingSource, "Phone Number", True))
        Me.Phone_NumberTextBox.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone_NumberTextBox.Location = New System.Drawing.Point(129, 359)
        Me.Phone_NumberTextBox.Name = "Phone_NumberTextBox"
        Me.Phone_NumberTextBox.Size = New System.Drawing.Size(141, 33)
        Me.Phone_NumberTextBox.TabIndex = 115
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SkateboardBindingSource, "Email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(129, 405)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(141, 33)
        Me.EmailTextBox.TabIndex = 117
        '
        'Blue_SkateboardCheckBox
        '
        Me.Blue_SkateboardCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SkateboardBindingSource, "Blue Skateboard", True))
        Me.Blue_SkateboardCheckBox.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Blue_SkateboardCheckBox.ForeColor = System.Drawing.Color.White
        Me.Blue_SkateboardCheckBox.Location = New System.Drawing.Point(121, 107)
        Me.Blue_SkateboardCheckBox.Name = "Blue_SkateboardCheckBox"
        Me.Blue_SkateboardCheckBox.Size = New System.Drawing.Size(189, 35)
        Me.Blue_SkateboardCheckBox.TabIndex = 119
        Me.Blue_SkateboardCheckBox.Text = "Blue Skatboard - $100"
        Me.Blue_SkateboardCheckBox.UseVisualStyleBackColor = True
        '
        'Yellow_SkateboardCheckBox
        '
        Me.Yellow_SkateboardCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SkateboardBindingSource, "Yellow Skateboard", True))
        Me.Yellow_SkateboardCheckBox.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Yellow_SkateboardCheckBox.ForeColor = System.Drawing.Color.White
        Me.Yellow_SkateboardCheckBox.Location = New System.Drawing.Point(121, 119)
        Me.Yellow_SkateboardCheckBox.Name = "Yellow_SkateboardCheckBox"
        Me.Yellow_SkateboardCheckBox.Size = New System.Drawing.Size(189, 62)
        Me.Yellow_SkateboardCheckBox.TabIndex = 121
        Me.Yellow_SkateboardCheckBox.Text = "Yellow Skateboard - $100"
        Me.Yellow_SkateboardCheckBox.UseVisualStyleBackColor = True
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SkateboardBindingSource, "Quantity", True))
        Me.QuantityTextBox.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTextBox.Location = New System.Drawing.Point(129, 451)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(141, 33)
        Me.QuantityTextBox.TabIndex = 123
        '
        'Total_PriceTextBox
        '
        Me.Total_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SkateboardBindingSource, "Total Price", True))
        Me.Total_PriceTextBox.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_PriceTextBox.Location = New System.Drawing.Point(129, 495)
        Me.Total_PriceTextBox.Name = "Total_PriceTextBox"
        Me.Total_PriceTextBox.Size = New System.Drawing.Size(141, 33)
        Me.Total_PriceTextBox.TabIndex = 125
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.ToolStripButton1
        Me.BindingNavigator1.AllowDrop = True
        Me.BindingNavigator1.BindingSource = Me.SkateboardBindingSource
        Me.BindingNavigator1.CountItem = Me.ToolStripLabel1
        Me.BindingNavigator1.DeleteItem = Me.ToolStripButton2
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton7})
        Me.BindingNavigator1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.BindingNavigator1.Location = New System.Drawing.Point(12, 30)
        Me.BindingNavigator1.MoveFirstItem = Me.ToolStripButton3
        Me.BindingNavigator1.MoveLastItem = Me.ToolStripButton6
        Me.BindingNavigator1.MoveNextItem = Me.ToolStripButton5
        Me.BindingNavigator1.MovePreviousItem = Me.ToolStripButton4
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.ToolStripTextBox1
        Me.BindingNavigator1.Size = New System.Drawing.Size(267, 23)
        Me.BindingNavigator1.TabIndex = 106
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 20)
        Me.ToolStripButton1.Text = "Add new"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 15)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 20)
        Me.ToolStripButton2.Text = "Delete"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 20)
        Me.ToolStripButton3.Text = "Move first"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 20)
        Me.ToolStripButton4.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 20)
        Me.ToolStripButton5.Text = "Move next"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 20)
        Me.ToolStripButton6.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 20)
        Me.ToolStripButton7.Text = "Save Data"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(358, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 100)
        Me.Button1.TabIndex = 104
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(594, 75)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(401, 401)
        Me.PictureBox1.TabIndex = 103
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(19, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 25)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Select Skateboard:"
        '
        'SkateboardTableAdapter
        '
        Me.SkateboardTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SkateboardTableAdapter = Me.SkateboardTableAdapter
        Me.TableAdapterManager.UpdateOrder = SkateboardShop.SkateboardShopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(316, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 50)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "PLEASE FILL ALL THE TEXT FIELDS " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BEFORE PROCEEDING TO CHECKOUT!!!"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1034, 561)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Full_NameLabel)
        Me.Controls.Add(Me.Full_NameTextBox)
        Me.Controls.Add(Home_AddressLabel)
        Me.Controls.Add(Me.Home_AddressTextBox)
        Me.Controls.Add(Postal_CodeLabel)
        Me.Controls.Add(Me.Postal_CodeTextBox)
        Me.Controls.Add(Phone_NumberLabel)
        Me.Controls.Add(Me.Phone_NumberTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Blue_SkateboardLabel)
        Me.Controls.Add(Me.Blue_SkateboardCheckBox)
        Me.Controls.Add(Yellow_SkateboardLabel)
        Me.Controls.Add(Me.Yellow_SkateboardCheckBox)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Total_PriceLabel)
        Me.Controls.Add(Me.Total_PriceTextBox)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1050, 600)
        Me.MinimumSize = New System.Drawing.Size(1050, 600)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Skateboard - Sam Kapoor"
        CType(Me.SkateboardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkateboardShopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SkateboardShopDataSet As SkateboardShopDataSet
    Friend WithEvents SkateboardBindingSource As BindingSource
    Friend WithEvents SkateboardTableAdapter As SkateboardShopDataSetTableAdapters.SkateboardTableAdapter
    Friend WithEvents TableAdapterManager As SkateboardShopDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button2 As Button
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Full_NameTextBox As TextBox
    Friend WithEvents Home_AddressTextBox As TextBox
    Friend WithEvents Postal_CodeTextBox As TextBox
    Friend WithEvents Phone_NumberTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Blue_SkateboardCheckBox As CheckBox
    Friend WithEvents Yellow_SkateboardCheckBox As CheckBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents Total_PriceTextBox As TextBox
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
