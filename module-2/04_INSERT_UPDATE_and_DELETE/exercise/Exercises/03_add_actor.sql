-- 3. Did you know Eric Stoltz was originally cast as Marty McFly in "Back to the Future"? 
-- Add Eric Stoltz to the list of actors for "Back to the Future" (1 row)


begin tran

INSERT INTO movie_actor
SELECT
(SELECT movie_id FROM movie
WHERE title = 'Back to the Future'), (SELECT person_id FROM person WHERE person_name = 'Eric Stoltz')

SELECT * FROM movie_actor 
WHERE movie_id = 105
rollback
