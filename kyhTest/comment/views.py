from django.http import HttpResponse

def list(request):
    return HttpResponse("This is a contact list.")
