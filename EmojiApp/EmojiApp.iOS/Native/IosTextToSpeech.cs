using AVFoundation;
using EmojiApp.Infrastructure.Native;
using EmojiApp.iOS.Native;
using System;

[assembly: Xamarin.Forms.Dependency(typeof(IosTextToSpeech))]
namespace EmojiApp.iOS.Native
{
    public class IosTextToSpeech : ITextToSpeech
    {
        public IosTextToSpeech() { }

        public void Speak(string text)
        {
            var speechSynthesizer = new AVSpeechSynthesizer();
            var speechUtterance = new AVSpeechUtterance(text)
            {
                Rate = AVSpeechUtterance.MaximumSpeechRate / 4,
                Voice = AVSpeechSynthesisVoice.FromLanguage("en-US"),
                Volume = 0.5f,
                PitchMultiplier = 1.0f
            };

            speechSynthesizer.SpeakUtterance(speechUtterance);
        }

    }
}