USE master;
GO

DROP DATABASE IF EXISTS Meetups;

CREATE DATABASE Meetups;
GO

USE Meetups
GO

BEGIN TRANSACTION;

CREATE TABLE member
(
	memberNumber	int		identity(1,1),
	lastName	varchar(64)		not null,
	firstName	varchar(64)		not null,
	email		varchar(100)	not null,
	phoneNumber varchar(11)		null,
	birthDate	date			not null,
	reminders	bit				
	
	constraint pk_member primary key (memberNumber)
);

CREATE TABLE interestGroup
(
	groupNumber		int		identity(1,1),
	groupName	varchar(100)	not null,

	constraint pk_interestGroup primary key (groupNumber)
);

CREATE TABLE groupMember
(
	memberNumber	int		not null,
	groupNumber		int		not null,

	constraint fk_groupMember_member foreign key (memberNumber) references member (memberNumber),
	constraint fk_groupMember_interestGroup foreign key (groupNumber) references interestGroup (groupNumber)
);

CREATE TABLE event
(
	eventNumber		int		identity(1,1),
	eventName	varchar(100)	not null,
	description varchar(100)	not null,
	startDate	date			not null,
	startTime	varchar(10)		not null,
	duration	varchar(64)		not null,
	hostGroup	int				not null,

	constraint pk_event primary key (eventNumber),
	constraint fk_event_interestGroup foreign key (hostGroup) references interestGroup (groupNumber)
);

CREATE TABLE eventMember 
(
	memberNumber	int		not null,
	eventNumber		int		not null,

	constraint fk_eventMember_member foreign key (memberNumber) references member (memberNumber),
	constraint fk_eventMember_event foreign key (eventNumber) references event (eventNumber)
);

COMMIT TRANSACTION;



INSERT INTO member (firstName, lastName, birthDate, email, reminders)
VALUES ('Bob', 'Smith', '03/19/1998', 'bobsmith6@gmail.com', 0)

INSERT INTO member (firstName, lastName, birthDate, email, reminders)
VALUES ('Jeff', 'Robinson', '11/21/1968', 'jrob54@gmail.com', 1)

INSERT INTO member (firstName, lastName, birthDate, email, reminders)
VALUES ('Chris', 'Washington', '05/02/2001', 'ctw1543@gmail.com', 1)

INSERT INTO member (firstName, lastName, birthDate, email, reminders)
VALUES ('Steve', 'Smiff', '10/02/1999', 'ssmiff651@gmail.com', 0)

INSERT INTO member (firstName, lastName, birthDate, email, reminders)
VALUES ('Cedric', 'Duke', '08/08/1987', 'cedricd45@gmail.com', 1)

INSERT INTO member (firstName, lastName, birthDate, email, reminders)
VALUES ('George', 'Johnson', '02/26/1973', 'georgej21@gmail.com', 0)

INSERT INTO member (firstName, lastName, birthDate, email, reminders)
VALUES ('Henry', 'Smoot', '05/12/1961', 'claudehenry@gmail.com', 0)

INSERT INTO member (firstName, lastName, birthDate, email, reminders)
VALUES ('Jake', 'Nelson', '07/21/1999', 'jaken132@gmail.com', 0)


INSERT INTO interestGroup (groupName)
VALUES ('Bird Watchers')

INSERT INTO interestGroup (groupName)
VALUES ('Chess Club')

INSERT INTO interestGroup (groupName)
VALUES ('DIY Barbers')


INSERT INTO event (eventName, description, startDate, startTime, duration, hostGroup)
VALUES ('Bird Watching', 'Come and watch some birds, then go home.', '02/21/2022', '12:00 PM', '12:00 PM - 6:00 PM', 
(SELECT groupNumber FROM interestGroup WHERE groupName = 'Bird Watchers')) 

INSERT INTO event (eventName, description, startDate, startTime, duration, hostGroup)
VALUES ('Chess Tournament', 'See who the best chess player is with a tournament.', '03/30/2022', '8:00 AM', '8:00 AM - 3:00 PM', 
(SELECT groupNumber FROM interestGroup WHERE groupName = 'Chess Club'))

INSERT INTO event (eventName, description, startDate, startTime, duration, hostGroup)
VALUES ('Haircut Strategy Meeting', 'Get tips from the pros and learn to cut your own hair.', '05/23/2022', '2:00 PM', '2:00 PM - 4:00 PM', 
(SELECT groupNumber FROM interestGroup WHERE groupName = 'DIY Barbers'))

INSERT INTO event (eventName, description, startDate, startTime, duration, hostGroup)
VALUES ('Bird Watchers vs. Chess Club', 'The brawl of a lifetime. Anything goes.', '12/24/2022', '1:00 PM', '1:00 PM - 6:00 PM', 
(SELECT groupNumber FROM interestGroup WHERE groupName = 'Bird Watchers'))


INSERT INTO groupMember (memberNumber, groupNumber)
VALUES 
((SELECT memberNumber FROM member WHERE firstName = 'Jake' AND lastName = 'Nelson'),
(SELECT groupNumber FROM interestGroup WHERE groupName = 'DIY Barbers'))

INSERT INTO groupMember (memberNumber, groupNumber)
VALUES 
((SELECT memberNumber FROM member WHERE firstName = 'Jake' AND lastName = 'Nelson'),
(SELECT groupNumber FROM interestGroup WHERE groupName = 'Bird Watchers'))

INSERT INTO groupMember (memberNumber, groupNumber)
VALUES 
((SELECT memberNumber FROM member WHERE firstName = 'Henry' AND lastName = 'Smoot'),
(SELECT groupNumber FROM interestGroup WHERE groupName = 'Chess Club'))

INSERT INTO groupMember (memberNumber, groupNumber)
VALUES 
((SELECT memberNumber FROM member WHERE firstName = 'Bob' AND lastName = 'Smith'),
(SELECT groupNumber FROM interestGroup WHERE groupName = 'Chess Club'))

INSERT INTO groupMember (memberNumber, groupNumber)
VALUES 
((SELECT memberNumber FROM member WHERE firstName = 'Cedric' AND lastName = 'Duke'),
(SELECT groupNumber FROM interestGroup WHERE groupName = 'Bird Watchers'))

INSERT INTO groupMember (memberNumber, groupNumber)
VALUES 
((SELECT memberNumber FROM member WHERE firstName = 'George' AND lastName = 'Johnson'),
(SELECT groupNumber FROM interestGroup WHERE groupName = 'DIY Barbers'))


INSERT INTO eventMember (memberNumber, eventNumber)
VALUES
((SELECT memberNumber FROM member WHERE firstName = 'Jake' AND lastName = 'Nelson'),
(SELECT eventNumber FROM event WHERE eventName = 'Bird Watching'))

INSERT INTO eventMember (memberNumber, eventNumber)
VALUES
((SELECT memberNumber FROM member WHERE firstName = 'Jake' AND lastName = 'Nelson'),
(SELECT eventNumber FROM event WHERE eventName = 'Bird Watchers vs. Chess Club'))

INSERT INTO eventMember (memberNumber, eventNumber)
VALUES
((SELECT memberNumber FROM member WHERE firstName = 'Bob' AND lastName = 'Smith'),
(SELECT eventNumber FROM event WHERE eventName = 'Bird Watchers vs. Chess Club'))

INSERT INTO eventMember (memberNumber, eventNumber)
VALUES
((SELECT memberNumber FROM member WHERE firstName = 'Henry' AND lastName = 'Smoot'),
(SELECT eventNumber FROM event WHERE eventName = 'Chess Tournament'))

INSERT INTO eventMember (memberNumber, eventNumber)
VALUES
((SELECT memberNumber FROM member WHERE firstName = 'Bob' AND lastName = 'Smith'),
(SELECT eventNumber FROM event WHERE eventName = 'Chess Tournament'))

INSERT INTO eventMember (memberNumber, eventNumber)
VALUES
((SELECT memberNumber FROM member WHERE firstName = 'Cedric' AND lastName = 'Duke'),
(SELECT eventNumber FROM event WHERE eventName = 'Bird Watching'))

INSERT INTO eventMember (memberNumber, eventNumber)
VALUES
((SELECT memberNumber FROM member WHERE firstName = 'Jake' AND lastName = 'Nelson'),
(SELECT eventNumber FROM event WHERE eventName = 'Haircut Strategy Meeting'))

INSERT INTO eventMember (memberNumber, eventNumber)
VALUES
((SELECT memberNumber FROM member WHERE firstName = 'George' AND lastName = 'Johnson'),
(SELECT eventNumber FROM event WHERE eventName = 'Haircut Strategy Meeting'))
