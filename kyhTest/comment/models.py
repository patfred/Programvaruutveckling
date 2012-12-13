from django.db import models
from kyhTest.content.models import Company
from kyhTest.content.models import Tag

class Comment(models.Model):
	comment = models.CharField(max_length = 1024)
	contact = models.ForeignKey('Contact')
