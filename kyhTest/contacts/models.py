from django.db import models
from kyhTest.content.models import Company

class Contact(models.Model):
	
	first_name = models.CharField(max_length = 45)
	last_name = models.CharField(max_length = 45)
	title = models.CharField(max_length = 45)
	phone = models.CharField(max_length = 45)
	email = models.CharField(max_length = 45)
	description = models.CharField(max_length = 45)
	company = models.ForeignKey('Company')
