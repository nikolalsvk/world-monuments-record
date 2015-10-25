using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektniZadatak_NikolaDjuza.Custom
{
    class MyButtonCell : System.Windows.Forms.DataGridViewButtonCell
    {
        protected override void Paint(System.Drawing.Graphics graphics, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle cellBounds, int rowIndex, System.Windows.Forms.DataGridViewElementStates elementState, object value, object formattedValue, string errorText, System.Windows.Forms.DataGridViewCellStyle cellStyle, System.Windows.Forms.DataGridViewAdvancedBorderStyle advancedBorderStyle, System.Windows.Forms.DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
            //System.Windows.Forms.ButtonRenderer.DrawButton(graphics, cellBounds, formattedValue.ToString(), new Font("Comic Sans MS", 9.0f, FontStyle.Bold), true, System.Windows.Forms.VisualStyles.PushButtonState.Default));
        }
    }
}
