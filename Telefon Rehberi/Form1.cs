using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelefonRehberi.Bussiness.Absract;
using TelefonRehberi.Bussiness.Concrete;
using TelefonRehberi.Bussiness.DependencyResolvers.ninject;
using TelefonRehberi.DataAccess.Concrete.EntityFramework;
using TelefonRehberi.Entities.Concrete;

namespace Telefon_Rehberi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _directoryService = InstanceFactory.GetInstance<IDirectoryService>();

        }
        private IDirectoryService _directoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDirectories();
        }

        private void LoadDirectories()
        {

            dgwDirectories.DataSource = _directoryService.GetAll();
        }

        private void tbxNamaAndSurnameSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(tbxNamaAndSurnameSearch.Text))
                {
                    LoadDirectories();
                }
                else
                {
                    dgwDirectories.DataSource = _directoryService.GetDirectoriesByNameAndSurname(tbxNamaAndSurnameSearch.Text);
                }
            }
            catch 
            {

                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _directoryService.Delete(new Directory
            {
                Id = Convert.ToInt32(dgwDirectories.CurrentRow.Cells[0].Value)
            });
            LoadDirectories();
            MessageBox.Show("Başarıyla Silindi!!");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _directoryService.Add(new Directory
                {
                    NameAndSurname = tbxNameAndSurname.Text,
                    EmailAdress = tbxEmailAdress.Text,
                    PhoneNumber = Convert.ToInt64(tbxPhoneNumber.Text)
                });
                LoadDirectories();
                MessageBox.Show("Başarıyla Eklendi!!");
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.ToString());
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _directoryService.Update(new Directory
                {
                    Id = Convert.ToInt32(dgwDirectories.CurrentRow.Cells[0].Value),
                    NameAndSurname = tbxNameAndSurnameUpdate.Text,
                    EmailAdress = tbxEmailAdressUpdate.Text,
                    PhoneNumber = Convert.ToInt64(tbxPhoneNumberUpdate.Text)
                });
                LoadDirectories();
                MessageBox.Show("Başarıyla güncellendi!!");
            }           
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void dgwDirectories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameAndSurnameUpdate.Text = dgwDirectories.CurrentRow.Cells[1].Value.ToString();
            tbxEmailAdressUpdate.Text = dgwDirectories.CurrentRow.Cells[2].Value.ToString();
            tbxPhoneNumberUpdate.Text = dgwDirectories.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
