FROM php:7.2-apache
COPY src/ /var/www/html/
EXPOSE 80

FROM php:7.4-apache
RUN pecl install redis && docker-php-ext-enable redis