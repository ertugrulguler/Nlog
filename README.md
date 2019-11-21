# Nlog

Nlog projede oluşan hataları loglamamızı sağlayan bir dll'dir.

### Nlog Kullanımı

1.Nugetten Nlog ve Nlog.Config yüklenmeli.      <br>
2.Eğer mail atılacak ise Nlog.MailKit de yüklenmeli.  <br>
3.Çeşitli yapılandırmalar Nlog.config den yapıldıktan sonra :  <br><br>
            var logger = LogManager.GetCurrentClassLogger();  <br>
            logger.Error(filterContext.Exception.Message);  <br> <br>
  gibi bir yapı ile Nlog harekete geçirilmelidir.
