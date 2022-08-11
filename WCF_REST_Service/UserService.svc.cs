using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
using WCF_REST_Service.Model;

namespace WCF_REST_Service
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "UserService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione UserService.svc o UserService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class UserService : IUserService
    {
        UsersManagementEntities ctx;

        public UserService()
        {
            ctx = new UsersManagementEntities();
        }

        public List<UserDataContract> GetAllUsers()
        {
            var query = (from a in ctx.Users
                            //where a.UserID.Equals(1087)
                         select a).Distinct();

            List<UserDataContract> userList = new List<UserDataContract>();

            query.ToList().ForEach(rec =>
            {
                userList.Add(new UserDataContract
                {
                    UserID = Convert.ToString(rec.UserID),
                   
                    /***********************/
                    PrimerApellido = rec.PrimerApellido,
                    SegundoApellido = rec.SegundoApellido,
                    PrimerNombre = rec.PrimerNombre,
                    OtrosNombres = rec.OtrosNombres,
                    PaisEmpleo = rec.PaisEmpleo,
                    TipoIdentificacion = rec.TipoIdentificacion,
                    NumeroIdentificacion = rec.NumeroIdentificacion,
                    CorreoElectronico = rec.CorreoElectronico,
                    FechaIngreso = rec.FechaIngreso,
                    Area = rec.Area,
                    Estado = rec.Estado,
                    FechaHoraRegistro = (DateTime)rec.FechaHoraRegistro,
                    FechaHoraActualizado = (DateTime)rec.FechaHoraActualizado



                    /***********************/
                });
            });
            return userList;
        }

        public List<UserDataContract> GetAllUsersEmail(string email)
        {
            var query = (from a in ctx.Users
                             where a.UserID.Equals(email)
                         select a).Distinct();

            List<UserDataContract> userList = new List<UserDataContract>();
            query.ToString().Any();

            query.ToList().ForEach(rec =>
            {
                userList.Add(new UserDataContract
                {
                    UserID = Convert.ToString(rec.UserID),

                    /***********************/
                    PrimerApellido = rec.PrimerApellido,
                    SegundoApellido = rec.SegundoApellido,
                    PrimerNombre = rec.PrimerNombre,
                    OtrosNombres = rec.OtrosNombres,
                    PaisEmpleo = rec.PaisEmpleo,
                    TipoIdentificacion = rec.TipoIdentificacion,
                    NumeroIdentificacion = rec.NumeroIdentificacion,
                    CorreoElectronico = rec.CorreoElectronico,
                    FechaIngreso = rec.FechaIngreso,
                    Area = rec.Area,
                    Estado = rec.Estado,
                    FechaHoraRegistro = (DateTime)rec.FechaHoraRegistro,
                    FechaHoraActualizado = (DateTime)rec.FechaHoraActualizado
                    /***********************/
                });
            });
            return userList;
        }


        public List<UserDataContract> getAllUsersFilter()
        {
            var query = (from a in ctx.Users
                         select a).Distinct();

            List<UserDataContract> userList = new List<UserDataContract>();

            query.ToList().ForEach(rec =>
            {
                userList.Add(new UserDataContract
                {
                    UserID = Convert.ToString(rec.UserID),

                    /***********************/
                    PrimerApellido = rec.PrimerApellido,
                    SegundoApellido = rec.SegundoApellido,
                    PrimerNombre = rec.PrimerNombre,
                    OtrosNombres = rec.OtrosNombres,
                    PaisEmpleo = rec.PaisEmpleo,
                    TipoIdentificacion = rec.TipoIdentificacion,
                    NumeroIdentificacion = rec.NumeroIdentificacion,
                    CorreoElectronico = rec.CorreoElectronico,
                    FechaIngreso = rec.FechaIngreso,
                    Area = rec.Area,
                    Estado = rec.Estado,
                    FechaHoraRegistro = (DateTime)rec.FechaHoraRegistro,
                    FechaHoraActualizado = (DateTime)rec.FechaHoraActualizado



                    /***********************/
                });
            });
            return userList;
        }


        public UserDataContract GetUserDetails(string UserID)
        {
            UserDataContract user = new UserDataContract();

            try
            {
                int Emp_ID = Convert.ToInt32(UserID);
                var query = (from a in ctx.Users
                             where a.UserID.Equals(Emp_ID)
                             select a).Distinct().FirstOrDefault();

                user.UserID = Convert.ToString(query.UserID);


                /********************************/

                user.PrimerApellido = query.PrimerApellido;
                user.SegundoApellido = query.SegundoApellido;
                user.PrimerNombre = query.PrimerNombre;
                user.OtrosNombres = query.OtrosNombres;
                user.PaisEmpleo = query.PaisEmpleo;
                user.TipoIdentificacion = query.TipoIdentificacion;
                user.NumeroIdentificacion = query.NumeroIdentificacion;
                user.CorreoElectronico = query.CorreoElectronico;
                user.FechaIngreso = query.FechaIngreso;
                user.Area = query.Area;
                user.Estado = query.Estado;
                user.FechaHoraRegistro = (DateTime)query.FechaHoraRegistro;
                user.FechaHoraActualizado = (DateTime)query.FechaHoraActualizado;


                /********************************/

            }
            catch (Exception ex)
            {
                throw new FaultException<string>
                        (ex.Message);
            }
            return user;
        }

        public bool AddNewUser(UserDataContract user)
        {
            try
            {
                Users usr = ctx.Users.Create();
                DateTime diaActual = DateTime.Now;

                /***************************/
                 usr.PrimerApellido = user.PrimerApellido;
                 usr.SegundoApellido = user.SegundoApellido;
                 usr.PrimerNombre = user.PrimerNombre;
                 usr.OtrosNombres = user.OtrosNombres;
                 usr.PaisEmpleo = user.PaisEmpleo;
                 usr.TipoIdentificacion = user.TipoIdentificacion;
                 usr.NumeroIdentificacion = user.NumeroIdentificacion;
                string correoStrg = "";
                if (user.PaisEmpleo == "Colombia") {
                     correoStrg = user.PrimerNombre + "." + user.PrimerApellido + "@cidenet.com.co";
                } else {
                    correoStrg = user.PrimerNombre + "." + user.PrimerApellido + "@cidenet.com.us";
                } 

                usr.CorreoElectronico = correoStrg;
                usr.FechaIngreso = user.FechaIngreso;
                usr.Area = user.Area;
                usr.Estado = user.Estado;
                usr.FechaHoraRegistro = diaActual;
                usr.FechaHoraActualizado = diaActual; 

                ctx.Users.Add(usr);
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new FaultException<string>
                        (ex.Message);
            }
            return true;
        }

        public void UpdateUser(UserDataContract user)
        {
            try
            {
                int User_Id = Convert.ToInt32(user.UserID);
                Users usr = ctx.Users.Where(rec => rec.UserID == User_Id).FirstOrDefault();
                DateTime diaActual = DateTime.Now;

                /***********************/

                usr.PrimerApellido = user.PrimerApellido;
                usr.SegundoApellido = user.SegundoApellido;
                usr.PrimerNombre = user.PrimerNombre;
                usr.OtrosNombres = user.OtrosNombres;
                usr.PaisEmpleo = user.PaisEmpleo;
                usr.TipoIdentificacion = user.TipoIdentificacion;
                usr.NumeroIdentificacion = user.NumeroIdentificacion;

                string correoStrg = "";
                if (user.PaisEmpleo == "Colombia")
                {
                    correoStrg = user.PrimerNombre + "." + user.PrimerApellido + "@cidenet.com.co";
                }
                else
                {
                    correoStrg = user.PrimerNombre + "." + user.PrimerApellido + "@cidenet.com.us";
                }
                usr.CorreoElectronico = correoStrg;
                usr.FechaIngreso = user.FechaIngreso;
                usr.Area = user.Area;
                usr.Estado = user.Estado;
                usr.FechaHoraRegistro = user.FechaHoraRegistro;
                usr.FechaHoraActualizado = diaActual;   
                /***********************/


                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new FaultException<string>
                        (ex.Message);
            }
        }


        public void DeleteUser(string UserId)
        {
            try
            {
                int User_Id = Convert.ToInt32(UserId);
                Users usr = ctx.Users.Where(rec => rec.UserID == User_Id).FirstOrDefault();
                ctx.Users.Remove(usr);
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new FaultException<string>
                        (ex.Message);
            }
        }

    }
}
