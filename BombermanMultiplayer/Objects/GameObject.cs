using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Media;
using System.Diagnostics;

namespace BombermanMultiplayer
{
    [Serializable]
    public abstract class GameObject
    {
        protected Rectangle _Source;

        protected string Name;

        [NonSerialized]
        protected Image Sprite;

        protected int _frameindex;

        protected float _frameTime = 125;
        
        protected int _totalElapsedTime = 0;

        protected int _totalFrames;

        protected int[] _CasePosition;

        #region Accessors
        public int[] CasePosition
        {
             get { return _CasePosition; }
             set
             {
                if (!(value[0] < 0 || value[1] < 0))
                {
                    _CasePosition = value;
                }
            }

        }

        public Rectangle Source
        {
            get { return _Source; }
            set { _Source = value; }
        }

        public float frameSpeed
        {
            get { return this._frameTime; }
            set
            {
                if (value <= 0) this._frameTime = 1; //Pas de temps négatif
                else this._frameTime = value;
            }
        }

        public int totalFrames
        {
            get { return _totalFrames; }
        }

        public int frameindex
        {
            get { return _frameindex; }
            set { _frameindex = value; }
        }
        #endregion

        public GameObject()
        { }

        public GameObject(int x, int y, int totalFrames, int frameWidth, int frameHeight)
        {
            _totalFrames = totalFrames;
            CasePosition = new int[2] { 0, 0 };
            _Source = new Rectangle(x, y, frameWidth, frameHeight);
        }

        public GameObject(int x, int y, int totalFrames, int frameWidth, int frameHeight, int frameTime)
        {
            _totalFrames = totalFrames;
            CasePosition = new int[2] { 0, 0 };
            _Source = new Rectangle(x, y, frameWidth, frameHeight);
            _frameTime = frameTime;
        }

        public void ChangeLocation(int x, int y)
        {
            this._Source.X = x;
            this._Source.Y = y;
        }

        public void LoadSprite(Image sprite)
        {
            this.Sprite = sprite;
        }

        public void UnloadSprite()
        {
            this.Sprite = null;
        }

        #region Template pattern
        public virtual bool IsImageNeeded()
        {
            return false;
        }

        public virtual bool IsRectangleNeeded()
        {
            return false;
        }
        public virtual bool IsStringNeeded()
        {
            return false;
        }

        public virtual void DrawImage(Graphics gr)
        {
            gr.DrawImage(this.Sprite, Source, frameindex * Source.Width, 0, Source.Width, Source.Height, GraphicsUnit.Pixel);
        }

        public void DrawNeededPaintings(Graphics gr)
        {
            if (this.Sprite != null)
            {
                if (IsImageNeeded())
                {
                    DrawImage(gr);
                }
                if (IsRectangleNeeded())
                {
                    gr.DrawRectangle(Pens.Red, this.Source);
                }
                if (IsStringNeeded())
                {
                    gr.DrawString(this.Name, new Font(new Font("Arial", 10), FontStyle.Bold), Brushes.MediumVioletRed, this.Source.X, this.Source.Y - this.Source.Height / 2);
                }
            }
        }

        #endregion
        
        public void UpdateFrame(int elsapedTime)
        {
            _totalElapsedTime += elsapedTime;

            if (_totalElapsedTime > this.frameSpeed)
            {
                frameindex += 1;

                _totalElapsedTime = 0;

                if (frameindex > _totalFrames)
                {
                    frameindex = 0;

                }
            }
        }

        public void Bouger(int deplX, int deplY)
        {
            _Source.X += deplX;
            _Source.Y += deplY;
        }
    }
}
