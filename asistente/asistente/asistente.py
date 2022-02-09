import pyttsx3
import speech_recognition as sr

listener = sr.Recognizer()

engine = pyttsx3.init()

voices = engine.getProperty('voices')
engine.setProperty('voice',voices[1].id)

engine.say('buenos dias hijo de tu puta madre')
engine.runAndWait()

try:
	with sr.Microphone() as source:
		print('Escuchando...')
		voice = listener.listen(source)
		rec = listener.recognize_google(voice)
		print(rec)
except:
	print('no se puede acceder al microfono')
	pass
