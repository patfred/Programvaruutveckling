from django.db import models
from kyhTest.content.models import Contact
from kyhTest.content.models import User

class Reminder(models.Model):
	event_date = models.DateField()
	reminder_date = models.DateField()
	message = models.CharField(max_length = 45)
	contact = models.ForeignKey('Contact')
	user = models.ForeignKey('User')
	
	
	