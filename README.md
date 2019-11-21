# Nlog

Nlog projede oluşan hataları loglamamızı sağlayan bir dll'dir.

#H3 Nlog Kullanımı

1.Nugetten Nlog ve Nlog.Config yüklenmeli.
2.Eğer mail atılacak ise Nlog.MailKit de yüklenmeli.
3.Çeşitli yapılandırmalar Nlog.config den yapıldıktan sonra :
            var logger = LogManager.GetCurrentClassLogger();
            logger.Error(filterContext.Exception.Message);
  gibi bir yapı ile Nlog harekete geçirilmelidir.
