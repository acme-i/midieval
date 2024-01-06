using System.Collections.Generic;
using System.Text;

namespace Sanford.Multimedia.Midi
{
    public class RawMessageEventArgs : MidiEventArgsBase
    {
        private readonly byte[] message;

        public RawMessageEventArgs(int message)
        {
            this.message = new byte[] { (byte)ShortMessage.UnpackStatus(message),
                    (byte)ShortMessage.UnpackData1(message),
                    (byte)ShortMessage.UnpackData2(message) };
        }

        public RawMessageEventArgs(byte status, byte data1, byte data2)
        {
            this.message = new byte[] { status, data1, data2 };
        }

        public byte[] Message
        {
            get
            {
                return message;
            }
        }
    }
}