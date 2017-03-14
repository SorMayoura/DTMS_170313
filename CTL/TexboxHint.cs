using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CTL
{

    public class TexboxHint : TextBox
{
    /// <summary>
    /// The text that will be presented as the watermak hint
    /// </summary>
    private string _textHint = "Input Text";
    /// <summary>
    /// Gets or Sets the text that will be presented as the watermak hint
    /// </summary>
    public string TextHint
    {
        get { return _textHint; }
        set { _textHint = value; }
    }

    /// <summary>
    /// Whether watermark effect is enabled or not
    /// </summary>
    private bool _hintActive = true;
    /// <summary>
    /// Gets or Sets whether watermark effect is enabled or not
    /// </summary>
    public bool HintActive
    {
        get { return _hintActive; }
        set { _hintActive = value; }
    }

    /// <summary>
    /// Create a new TextBox that supports watermak hint
    /// </summary>
    public TexboxHint()
    {
        this._hintActive = true;
        _textHint = this.Text;
        this.ForeColor = Color.Gray;

        GotFocus += (source, e) =>
        {
            RemoveWatermak();
        };

        LostFocus += (source, e) =>
        {
            ApplyWatermark();
        };

    }

    /// <summary>
    /// Remove watermark from the textbox
    /// </summary>
    public void RemoveWatermak()
    {
        if (this._hintActive)
        {
            this._hintActive = false;
            this.Text = "";
            this.ForeColor = Color.Black;
        }
    }

    /// <summary>
    /// Applywatermak immediately
    /// </summary>
    public void ApplyWatermark()
    {
        if (!this._hintActive && string.IsNullOrEmpty(this.Text)
            || ForeColor == Color.Gray ) 
        {
            this._hintActive = true;
            this.Text = _textHint;
            this.ForeColor = Color.Gray;
        }
    }

    /// <summary>
    /// Apply watermak to the textbox. 
    /// </summary>
    /// <param name="newText">Text to apply</param>
    public void ApplyWatermark(string newText)
    {
        TextHint = newText;
        ApplyWatermark();
    }

    }
}
