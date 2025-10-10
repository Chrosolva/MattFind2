using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DEPTHCHK
{
    public static class DataGridViewHelper
    {
        public static void ApplyDefaultStyle(DataGridView dgv, bool readOnly = true, bool multiSelect = false)
        {
            // General Appearance
            dgv.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dgv.RowTemplate.Height = 28;
            dgv.ColumnHeadersHeight = 32;
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.LightGray;
            dgv.BorderStyle = BorderStyle.FixedSingle;
            dgv.EnableHeadersVisualStyles = false;
            dgv.RowHeadersWidth = 25;

            // Header Style
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // Row Style
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

            // Column Behavior
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = true;
            dgv.AllowUserToResizeRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = multiSelect;


            // Read-only vs Editable
            dgv.ReadOnly = readOnly;
            if (!readOnly)
            {
                dgv.EditMode = DataGridViewEditMode.EditOnEnter;
            }

            // Performance tweak
            EnableDoubleBuffering(dgv);
        }

        private static void EnableDoubleBuffering(DataGridView dgv)
        {
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.SetProperty,
                null, dgv, new object[] { true });
        }

        public static void FitOnceThenUnlock(DataGridView dgv)
        {
            // 1) Auto-fit to fill on this pass
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Optional: tweak weights for nicer initial proportions
            foreach (DataGridViewColumn c in dgv.Columns)
            {
                c.Resizable = DataGridViewTriState.True;
                c.MinimumWidth = 60; // safety
                                     // c.FillWeight = 1f; // or set per column if needed
            }

            // 2) Freeze widths so user can freely resize after the initial fit
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

    }

}
