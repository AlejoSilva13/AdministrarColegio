using AdministrarColegio.Busines.Request;
using AdministrarColegio.Busines.Response;
using AdministrarColegio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;

namespace AdministrarColegio.Controllers
{
    [RoutePrefix("api/Admin")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AdministrarController : ApiController
    {
        private readonly BdAdministrarColegio bd;

        AdministrarController()
        {
            bd = new BdAdministrarColegio();
        }

        [HttpPost]
        [Route("insertarProfesor")]

        public JsonResult<InsertarProfesorRs> Insert(InsertarProfesorRq request)
        {
            InsertarProfesorRs response = new InsertarProfesorRs();

            try
            {
                Profesor profesor = bd.Profesor.Where(x => x.Identificacion == request.Identificacion).OrderByDescending(x => x.Id).FirstOrDefault();

                if(profesor == null)
                {
                    profesor = new Profesor
                    {
                        Identificacion = request.Identificacion,
                        Nombre = request.Nombre,
                        Apellido = request.Apellido,
                        Edad = request.Edad,
                        Direccion = request.Direccion,
                        Telefono = request.Telefono
                    };

                    bd.Profesor.Add(profesor);
                    bd.SaveChanges();

                    response.Mensaje = "Profesor insertado con exito";
                    response.IdError = 0;
                }
                else
                {
                    response.Mensaje = "Profesor ya existe";
                    response.IdError = -1;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return Json(response);
        }

        [HttpPost]
        [Route("insertarAsignatura")]

        public JsonResult<InsertarAsignaturaRs> InsertSubject(InsertarAsignaturaRq request)
        {
            InsertarAsignaturaRs response = new InsertarAsignaturaRs();

            try
            {
                Asignaturas asignaturas = bd.Asignaturas.Where(x => x.Codigo == request.Codigo).OrderByDescending(x => x.Id).FirstOrDefault();

                if(asignaturas == null)
                {
                    asignaturas = new Asignaturas
                    {
                        Codigo = request.Codigo,
                        Nombre = request.Nombre
                    };

                    bd.Asignaturas.Add(asignaturas);
                    bd.SaveChanges();

                    response.Mensaje = "Asignatura Inscrita con exito";
                    response.IdError = 0;
                }
                else
                {
                    response.Mensaje = "Asignatura ya fue inscrita";
                    response.IdError = -2;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            return Json(response);
        }

        [HttpPost]
        [Route("insertarAlumno")]

        public JsonResult<InsertarAlumnoRs> InsertStudent(InsertarAlumnoRq request)
        {
            InsertarAlumnoRs response = new InsertarAlumnoRs();

            try
            {
                Alumnos alumnos = bd.Alumnos.Where(x => x.Identificacion == request.Identificacion).OrderByDescending(x => x.Id).FirstOrDefault();

                if(alumnos == null)
                {
                    alumnos = new Alumnos
                    {
                        Identificacion = request.Identificacion,
                        Nombre = request.Nombre,
                        Apellido = request.Apellido,
                        Edad = request.Edad,
                        Direccion = request.Direccion,
                        Telefono = request.Telefono
                    };

                    bd.Alumnos.Add(alumnos);
                    bd.SaveChanges();

                    response.Mensaje = "Estudiante insertado con exito";
                    response.IdError = 0;
                }
                else
                {
                    response.Mensaje = "Estudiante ya existe";
                    response.IdError = 0;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return Json(response);
        }

        [HttpPut]
        [Route("actualizarAlumno")]

        public JsonResult<ActualizarEstudianteRs> UpdateStudent(ActualizarEstudianteRq request)
        {
            ActualizarEstudianteRs response = new ActualizarEstudianteRs();

            try
            {
                Alumnos alumnos = bd.Alumnos.Where(x => x.Identificacion == request.Identificacion).OrderByDescending(x => x.Id).FirstOrDefault();

                if(alumnos != null)
                {
                    alumnos.Identificacion = request.Identificacion;
                    alumnos.Nombre = request.Nombre;
                    alumnos.Apellido = request.Apellido;
                    alumnos.Edad = request.Edad;
                    alumnos.Direccion = request.Direccion;
                    alumnos.Telefono = request.Telefono;

                    bd.Entry(alumnos).State = EntityState.Modified;
                    bd.SaveChanges();

                    response.Mensaje = "Datos de estudiante actualizados con exito";
                    response.IdError = 0;
                }
                else
                {
                    response.Mensaje = "Estudiante no existe";
                    response.IdError = -3;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return Json(response);
        }

        [HttpPut]
        [Route("actualizarProfesor")]

        public JsonResult<ActualizarProfesorRs> UpdateTeacher(ActualizarProfesorRq request)
        {
            ActualizarProfesorRs response = new ActualizarProfesorRs();

            try
            {
                Profesor profesor = bd.Profesor.Where(x => x.Identificacion == request.Identificacion).OrderByDescending(x => x.Id).FirstOrDefault();

                if(profesor != null)
                {
                    profesor.Identificacion = request.Identificacion;
                    profesor.Nombre = request.Nombre;
                    profesor.Apellido = request.Apellido;
                    profesor.Edad = request.Edad;
                    profesor.Direccion = request.Direccion;
                    profesor.Telefono = request.Telefono;

                    bd.Entry(profesor).State = EntityState.Modified;
                    bd.SaveChanges();

                    response.Mensaje = "Datos de profesor actualizados con exito";
                    response.IdError = 0;
                }
                else
                {
                    response.Mensaje = "Profesor no existe";
                    response.IdError = -4;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return Json(response);
        }

        [HttpPost]
        [Route("asignarMateriasProfesor")]

        public JsonResult<AsignarMateriasProfesorRs> AssignTeacher(AsignarMateriasProfesorRq request)
        {
            AsignarMateriasProfesorRs response = new AsignarMateriasProfesorRs();

            try
            {
                Asignaturas asignaturas = bd.Asignaturas.Where(x => x.Codigo == request.Codigo).OrderByDescending(x => x.Id).FirstOrDefault();

                if(asignaturas != null)
                {
                    Profesor profesor = bd.Profesor.Where(x => x.Identificacion == request.Identificacion).OrderByDescending(x => x.Id).FirstOrDefault();

                    if (profesor != null)
                    {
                        MateriaProfesor materiaProfesor = bd.MateriaProfesor.Where(x => x.Codigo == asignaturas.Codigo).OrderByDescending(x => x.Id).FirstOrDefault();

                        if (materiaProfesor == null)
                        {
                            materiaProfesor = new MateriaProfesor
                            {
                                NombreMateria = asignaturas.Nombre,
                                NombreProfesor = profesor.Nombre,
                                Codigo = request.Codigo,
                                Identificacion = request.Identificacion
                            };

                            bd.MateriaProfesor.Add(materiaProfesor);
                            bd.SaveChanges();

                            response.Mensaje = $"Materia asignada con exito al Profesor {profesor.Nombre}";
                            response.IdError = 0;
                        }
                        else
                        {
                            response.Mensaje = "Materia ya asignada";
                            response.IdError = -5;
                        }
                    }
                    else
                    {
                        response.Mensaje = "Profesor no existe";
                        response.IdError = -99;
                    }
                }
                else
                {
                    response.Mensaje = "asignatura no existe";
                    response.IdError = -99;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return Json(response);
        }

        [HttpPost]
        [Route("asignarMateriasAlumno")]

        public JsonResult<AsignarMateriaAlumnoRs> AssignStudent(AsignarMateriaAlumnoRq request)
        {
            AsignarMateriaAlumnoRs response = new AsignarMateriaAlumnoRs();

            try
            {
                Asignaturas asignaturas = bd.Asignaturas.Where(x => x.Codigo == request.Codigo).OrderByDescending(x => x.Id).FirstOrDefault();

                if(asignaturas != null)
                {
                    Alumnos alumnos = bd.Alumnos.Where(x => x.Identificacion == request.Identificacion).OrderByDescending(x => x.Id).FirstOrDefault();

                    if (alumnos != null)
                    {
                        MateriaAlumno materiaAlumno = bd.MateriaAlumno.Where(x => x.AñoAcademico == request.AñoAcademico && x.CodigoMateria == request.Codigo).OrderByDescending(x => x.Id).FirstOrDefault();

                        if (materiaAlumno == null)
                        {
                            materiaAlumno = new MateriaAlumno
                            {
                                NombreMateria = asignaturas.Nombre,
                                NombreAlumno = alumnos.Nombre,
                                NotaFinal = request.NotaFinal,
                                CodigoMateria = asignaturas.Codigo,
                                AñoAcademico = request.AñoAcademico,
                                Identificacion = request.Identificacion
                            };

                            bd.MateriaAlumno.Add(materiaAlumno);
                            bd.SaveChanges();

                            response.Mensaje = $"Materia asignada con exito al alumno {alumnos.Nombre} con nota final de {materiaAlumno.NotaFinal}";
                            response.IdError = 0;
                        }
                        else
                        {
                            response.Mensaje = "Al estudiante ya se le asigno esta materia este año escolar";
                            response.IdError = -6;
                        }
                    }
                    else
                    {
                        response.Mensaje = "Alumno no existe";
                        response.IdError = -99;
                    }
                }
                else
                {
                    response.Mensaje = "Asignatura no existe";
                    response.IdError = -99;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return Json(response);
        }

        [HttpDelete]
        [Route("eliminarAlumnos")]

        public JsonResult<EliminarAlumnosRs> DeleteStudent(EliminarAlumnosRq request)
        {
            EliminarAlumnosRs response = new EliminarAlumnosRs();

            try
            {
                Alumnos alumnos = bd.Alumnos.Where(x => x.Identificacion == request.Identificacion).OrderByDescending(x => x.Id).FirstOrDefault();
                MateriaAlumno materiaAlumno = bd.MateriaAlumno.Where(x => x.Identificacion == alumnos.Identificacion).OrderByDescending(x => x.Id).FirstOrDefault();

                if(materiaAlumno == null)
                {
                    bd.Alumnos.Remove(alumnos);
                    bd.SaveChanges();

                    response.Mensaje = "Alumno eliminado con exito";
                    response.IdError = 0;
                }
                else
                {
                    response.Mensaje = "No es posible eliminar el alumno ya que tiene materias asignadas";
                    response.IdError = -99;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return Json(response);
        }

        [HttpGet]
        [Route("consultar")]

        public JsonResult<ConsultaRs> Consulting()
        {
            ConsultaRs response = new ConsultaRs();
            try
            {
                List<vw_InformacionColegio> lstInformacion = bd.vw_InformacionColegio.OrderByDescending(x => x.AñoAcademico).ToList();

                if(lstInformacion.Count > 0)
                {
                    response.Informacion = lstInformacion;
                    response.IdError = 0;
                    response.Mensaje = "Datos Obtenidos con exito";
                }
                else
                {
                    response.IdError = -8;
                    response.Mensaje = "No hay datos que mostrar la lista esta vacia";
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            return Json(response);
        }

        [HttpGet]
        [Route("consultarProfesores")]

        public JsonResult<ConsultarProfesorRs> ConsultingTeacher()
        {
            ConsultarProfesorRs response = new ConsultarProfesorRs();

            try
            {
                List<Profesor> lstProfesor = bd.Profesor.OrderByDescending(x => x.Id).ToList();

                if(lstProfesor.Count > 0)
                {
                    response.profesors = lstProfesor;
                }
                else
                {
                    response.Mensaje = "No hay datos";
                    response.IdError = -99;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return Json(response);
        }

        [HttpGet]
        [Route("consultarAlumno")]

        public JsonResult<ConsultarAlumnoRs> ConsultingStudent()
        {
            ConsultarAlumnoRs response = new ConsultarAlumnoRs();

            try
            {
                List<Alumnos> lstAlumnos = bd.Alumnos.OrderByDescending(x => x.Id).ToList();

                if(lstAlumnos.Count > 0)
                {
                    response.Alumno = lstAlumnos;
                }
                else
                {
                    response.Mensaje = "No hay datos";
                    response.IdError = -99;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return Json(response);
        }

        [HttpGet]
        [Route("consultarMateria")]

        public JsonResult<ConsultarMateriaRs> ConsultingSubject()
        {
            ConsultarMateriaRs response = new ConsultarMateriaRs();

            try
            {
                List<Asignaturas> lstAsignaturas = bd.Asignaturas.OrderByDescending(x => x.Id).ToList();

                if(lstAsignaturas.Count > 0)
                {
                    response.Asignaturas = lstAsignaturas;
                }
                else
                {
                    response.Mensaje = "No hay datos";
                    response.IdError = -99;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return Json(response);
        }
    }
}