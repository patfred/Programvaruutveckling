from django.db import models
from kyhTest.content.models import User

class EventLog(models.Model):
	description = models.TextField()
	date = models.DateField()
	user = models.ForeignKey('User')
	
	
	