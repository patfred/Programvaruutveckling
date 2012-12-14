from django.db import models
from kyhTest.content.models import Contact

class Statement(models.Model):
	content = models.CharField(max_length = 45)
	date = models.DateField()
	contact = models.ForeignKey('Contact')
	
	
	