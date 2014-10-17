using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using AssemblyLoader;
using SomeSerialiserLib;
using Transports;

namespace MainFormApp
{
    public partial class Form1 : Form
    {
        private const int xmlFilterIndex = 1;

        private const int binFilterIndex = 2;

        private const int lab3FilterIndex = 3;

        private TreeNode selectedNode;

        private LoaderSerializationBinder serializationBinder;

        private Type[] types;

        List<Transport> elements; /*= new List<Transport>
            {
               new Car(new InternalCombustionEngine(10,5),"ASD",4,true,4,4,10 ),
               new Plane(new Turbine(2),"QWE",2000,700,50,new Wing(500,10),false ),
               new Helicopter(new PistonlessRotaryEngine(5,10),"DFG",2000,0,1,new Screw(4,10),new Screw(2,1)  ),
               new TrolleyBus(new InternalCombustionEngine(10,5),"ASD",4,true,4,2,150,10,new Route(new Position(),new Position(), 10 ),50 )
            };*/


        public Form1()
        {
            InitializeComponent();
            types = Loader.Load("Libs");
            serializationBinder = new LoaderSerializationBinder(types);
        }


   

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            StopChanging();
            var nodeTag = e.Node.Tag as TreeNodeTag;
            if (nodeTag == null) return;

            if (nodeTag.ElementType.IsValueType || nodeTag.Value is String)
            {
                if (!nodeTag.PropertyInfo.CanWrite) return;
                selectedNode = e.Node;
                changeValueGroupBox.Enabled = true;
                changeValueButton.Enabled = true;
                selectedNode = e.Node;
                if (nodeTag.Value is int)
                {
                    integerNumericUpDown.Value = (int)nodeTag.Value;
                    integerNumericUpDown.Enabled = true;
                }
                else if (nodeTag.Value is String)
                {
                    stringTextBox.Text = nodeTag.Value.ToString();
                    stringTextBox.Enabled = true;
                }
                else if (nodeTag.Value is bool)
                {
                    if ((bool)nodeTag.Value)
                    {
                        booleanComboBox.SelectedIndex = 0;
                    }
                    else
                    {
                        booleanComboBox.SelectedIndex = 1;
                    }
                    booleanComboBox.Enabled = true;
                }
            }

        }

        private void StopChanging()
        {
            selectedNode = null;
            changeValueGroupBox.Enabled = false;
            changeValueButton.Enabled = false;
            integerNumericUpDown.Enabled = false;
            stringTextBox.Enabled = false;
            booleanComboBox.Enabled = false;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using ( var streamReader = new StreamReader(openFileDialog.FileName))
                {
                    try
                    {
                        if (openFileDialog.FilterIndex == xmlFilterIndex)
                        {
                            var serializer = new XmlSerializer(
                                typeof (List<Transport>),
                                types);

                            elements =
                                (List<Transport>)
                                    serializer.Deserialize(streamReader);
                        }
                        else if (openFileDialog.FilterIndex == binFilterIndex)
                        {
                            var serializer = new BinaryFormatter();
                            serializer.Binder = serializationBinder;
                            elements =
                                (List<Transport>)
                                    serializer.Deserialize(
                                        streamReader.BaseStream);
                        }
                        else if (openFileDialog.FilterIndex == lab3FilterIndex)
                        {
                            var serializer = new SomeSerialiser();
                            serializer.Binder = serializationBinder;
                            elements =
                                (List<Transport>)
                                    serializer.Deserialize(streamReader);
                        }
                    }
                    catch (SerializationException ex)
                    {
                        MessageBox.Show(ex.Message, "Lab3", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.InnerException.Message, "Lab3",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;

                    }
                    
                }
                treeView.Nodes.Add(TreeCreater.GetTree(elements));

            }
           

        }

        private void changeValueButton_Click(object sender, EventArgs e)
        {
            if (selectedNode != null)
            {
                var nodeTag = (TreeNodeTag)selectedNode.Tag;
                var parentTag = (TreeNodeTag)selectedNode.Parent.Tag;
                selectedNode.Name = nodeTag.PropertyInfo.Name + ":";
                if (nodeTag.Value is int)
                {
                    selectedNode.Name += integerNumericUpDown.Value;
                    nodeTag.PropertyInfo.SetValue(parentTag.Value, (int)integerNumericUpDown.Value);
                    nodeTag.Value = (int) integerNumericUpDown.Value;
                }
                else if (nodeTag.Value is String)
                {
                    selectedNode.Name += stringTextBox.Text;
                    nodeTag.PropertyInfo.SetValue(parentTag.Value, stringTextBox.Text);
                    nodeTag.Value = stringTextBox.Text;
                }
                else if (nodeTag.Value is bool)
                {
                    if (booleanComboBox.SelectedIndex == 0)
                    {
                        selectedNode.Name += "True";
                        nodeTag.PropertyInfo.SetValue(parentTag.Value, true);
                        nodeTag.Value = true;
                    }
                    else
                    {
                        selectedNode.Name += "False";
                        nodeTag.PropertyInfo.SetValue(parentTag.Value, false);
                        nodeTag.Value = false;
                    }
                }
                selectedNode.Text = selectedNode.Name;
            }
        }

        private void saveXmlButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using ( var streamWriter = new StreamWriter(saveFileDialog.FileName))
                {
                    if (saveFileDialog.FilterIndex == xmlFilterIndex)
                    {
                        var serializer = new XmlSerializer(
                            typeof (List<Transport>),
                            types);


                        serializer.Serialize(streamWriter, elements);
                    }
                    else if (saveFileDialog.FilterIndex == binFilterIndex)
                    {
                        var serializer = new BinaryFormatter();
                        serializer.Binder = serializationBinder;
                        serializer.Serialize(streamWriter.BaseStream, elements);
                    }
                    else if (saveFileDialog.FilterIndex == lab3FilterIndex)
                    {
                        var serializer = new SomeSerialiser();
                        serializer.Binder = serializationBinder;
                        serializer.Serialize(streamWriter, elements);

                    }

                }
            }
        }
    }
}
