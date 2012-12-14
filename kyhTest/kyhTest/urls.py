from django.conf.urls import patterns, include, url

# Uncomment the next two lines to enable the admin:
# from django.contrib import admin
# admin.autodiscover()

urlpatterns = patterns('',
    url(r'^$', 'accounts.views.login_user'),
    url(r'^contacts/list$', 'contacts.views.list'),

    # Examples:
    # url(r'^$', 'kyhTest.views.home', name='home'),
    # url(r'^kyhTest/', include('kyhTest.foo.urls')),

    # Uncomment the admin/doc line below to enable admin documentation:
    # url(r'^admin/doc/', include('django.contrib.admindocs.urls')),

    # Uncomment the next line to enable the admin:
    # url(r'^admin/', include(admin.site.urls)),
)

