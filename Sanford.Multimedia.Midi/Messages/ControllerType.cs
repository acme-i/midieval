#region License

/* Copyright (c) 2005 Leslie Sanford
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy 
 * of this software and associated documentation files (the "Software"), to 
 * deal in the Software without restriction, including without limitation the 
 * rights to use, copy, modify, merge, publish, distribute, sublicense, and/or 
 * sell copies of the Software, and to permit persons to whom the Software is 
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in 
 * all copies or substantial portions of the Software. 
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN 
 * THE SOFTWARE.
 */

#endregion

#region Contact

/*
 * Leslie Sanford
 * Email: jabberdabber@hotmail.com
 */

#endregion

namespace Sanford.Multimedia.Midi
{
    /// <summary>
    /// Defines constants for controller types.
    /// </summary>
    public enum ControllerType
    {
        /// <summary>
        /// The Bank Select coarse.
        /// </summary>
        BankSelect,

        /// <summary>
        /// The Modulation Wheel coarse.
        /// </summary>
        ModulationWheel,

        /// <summary>
        /// The Breath Control coarse.
        /// </summary>
        BreathControl,

        /// <summary>
        /// The Foot Pedal coarse.
        /// </summary>
        FootPedal = 4,

        /// <summary>
        /// The Portamento Time coarse.
        /// </summary>
        PortamentoTime,

        /// <summary>
        /// The Data Entry Slider coarse.
        /// </summary>
        DataEntrySlider,

        /// <summary>
        /// The Volume coarse. 7
        /// </summary>
        Volume,

        /// <summary>
        /// The Balance coarse.
        /// </summary>
        Balance,

        /// <summary>
        /// The Pan position coarse.
        /// </summary>
        Pan = 10,

        /// <summary>
        /// The Expression coarse.
        /// </summary>
        Expression,

        /// <summary>
        /// The Effect Control 1 coarse.
        /// </summary>
        EffectControl1,

        /// <summary>
        /// The Effect Control 2 coarse.
        /// </summary>
        EffectControl2,

        /// <summary>
        /// The General Puprose Slider 1
        /// </summary>
        GeneralPurposeSlider1 = 16,

        /// <summary>
        /// The General Puprose Slider 2
        /// </summary>
        GeneralPurposeSlider2,

        /// <summary>
        /// The General Puprose Slider 3
        /// </summary>
        GeneralPurposeSlider3,

        /// <summary>
        /// The General Puprose Slider 4
        /// </summary>
        GeneralPurposeSlider4,

        /// <summary>
        /// The Bank Select fine.
        /// </summary>
        BankSelectFine = 32,

        /// <summary>
        /// The Modulation Wheel fine.
        /// </summary>
        ModulationWheelFine,

        /// <summary>
        /// The Breath Control fine.
        /// </summary>
        BreathControlFine,

        /// <summary>
        /// The Foot Pedal fine.
        /// </summary>
        FootPedalFine = 36,

        /// <summary>
        /// The Portamento Time fine.
        /// </summary>
        PortamentoTimeFine,

        /// <summary>
        /// The Data Entry Slider fine.
        /// </summary>
        DataEntrySliderFine,

        /// <summary>
        /// The Volume fine.
        /// </summary>
        VolumeFine,

        /// <summary>
        /// The Balance fine.
        /// </summary>
        BalanceFine,

        /// <summary>
        /// The Pan position fine.
        /// </summary>
        PanFine = 42,

        /// <summary>
        /// The Expression fine.
        /// </summary>
        ExpressionFine,

        /// <summary>
        /// The Effect Control 1 fine.
        /// </summary>
        EffectControl1Fine,

        /// <summary>
        /// The Effect Control 2 fine.
        /// </summary>
        EffectControl2Fine,

        /// <summary>
        /// The Hold Pedal 1.
        /// </summary>
        HoldPedal1 = 64,

        /// <summary>
        /// The Portamento.
        /// </summary>
        Portamento,

        /// <summary>
        /// The Sustenuto Pedal.
        /// </summary>
        SustenutoPedal,

        /// <summary>
        /// The Soft Pedal.
        /// </summary>
        SoftPedal,

        /// <summary>
        /// The Legato Pedal.
        /// </summary>
        LegatoPedal,

        /// <summary>
        /// The Hold Pedal 2.
        /// </summary>
        HoldPedal2,

        /// <summary>
        /// The Sound Variation.
        /// </summary>
        SoundVariation,

        /// <summary>
        /// The Sound Timbre.
        /// </summary>
        SoundTimbre,

        /// <summary>
        /// The Sound Release Time.
        /// </summary>
        SoundReleaseTime,

        /// <summary>
        /// The Sound Attack Time.
        /// </summary>
        SoundAttackTime,

        /// <summary>
        /// The Sound Brightness.
        /// </summary>
        SoundBrightness,

        /// <summary>
        /// The Sound Control 6.
        /// </summary>
        SoundControl6,

        /// <summary>
        /// The Sound Control 7.
        /// </summary>
        SoundControl7,

        /// <summary>
        /// The Sound Control 8.
        /// </summary>
        SoundControl8,

        /// <summary>
        /// The Sound Control 9.
        /// </summary>
        SoundControl9,

        /// <summary>
        /// The Sound Control 10.
        /// </summary>
        SoundControl10,

        /// <summary>
        /// The General Purpose Button 1.
        /// </summary>
        GeneralPurposeButton1,

        /// <summary>
        /// The General Purpose Button 2.
        /// </summary>
        GeneralPurposeButton2,

        /// <summary>
        /// The General Purpose Button 3.
        /// </summary>
        GeneralPurposeButton3,

        /// <summary>
        /// The General Purpose Button 4.
        /// </summary>
        GeneralPurposeButton4,

        /// <summary>
        /// The Effects Level.
        /// </summary>
        EffectsLevel = 91,

        /// <summary>
        /// The Tremolo Level.
        /// </summary>
        TremoloLevel,
        
        /// <summary>
        /// The Chorus Level.
        /// </summary>
        ChorusLevel,

        /// <summary>
        /// The Celeste Level.
        /// </summary>
        CelesteLevel,

        /// <summary>
        /// The Phaser Level.
        /// </summary>
        PhaserLevel,

        /// <summary>
        /// The Data Button Increment.
        /// </summary>
        DataButtonIncrement,

        /// <summary>
        /// The Data Button Decrement.
        /// </summary>
        DataButtonDecrement,

        /// <summary>
        /// The NonRegistered Parameter Fine.
        /// </summary>
        NonRegisteredParameterFine,

        /// <summary>
        /// The NonRegistered Parameter Coarse.
        /// </summary>
        NonRegisteredParameterCoarse,

        /// <summary>
        /// The Registered Parameter Fine.
        /// </summary>
        RegisteredParameterFine,

        /// <summary>
        /// The Registered Parameter Coarse.
        /// </summary>
        RegisteredParameterCoarse,

        /// <summary>
        /// The All Sound Off.
        /// </summary>
        AllSoundOff = 120,

        /// <summary>
        /// The All Controllers Off.
        /// </summary>
        AllControllersOff,

        /// <summary>
        /// The Local Keyboard.
        /// </summary>
        LocalKeyboard,
        
        /// <summary>
        /// The All Notes Off.
        /// </summary>
        AllNotesOff,

        /// <summary>
        /// The Omni Mode Off.
        /// </summary>
        OmniModeOff,

        /// <summary>
        /// The Omni Mode On.
        /// </summary>
        OmniModeOn,

        /// <summary>
        /// The Mono Operation.
        /// </summary>
        MonoOperation,

        /// <summary>
        /// The Poly Operation.
        /// </summary>
        PolyOperation
    }
}