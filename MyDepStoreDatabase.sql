CREATE TABLE CLIENTS (
ID SERIAL primary key,
FIRST_NAME character(50) not null,
LAST_NAME character(50) not null,
ID_NUMBER integer,
ACTIVE boolean default(true);
