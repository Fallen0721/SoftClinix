using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoftClinix.Models
{
    [Table("registro_pacientes")]
    public class Paciente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }

        [Column("f_nacimiento")]
        public DateTime? FNacimiento { get; set; }

        [Column("estado_civil")]
        public string EstadoCivil { get; set; }
        public string Ocupacion { get; set; }
        [StringLength(8)]

        [Column("no_historia")]
        public string NoHistoria { get; set; }

        [Column("doc_identidad")]
        public string DocIdentidad { get; set; }
        public string Direccion { get; set; }
        public string Telefonos { get; set; }
        public string Email { get; set; }

        [Column("estado_historia")]
        public string EstadoHistoria { get; set; }

        [Column("plan_atencion")]
        public string PlanAtencion { get; set; }
        public string Medico { get; set; }

        [Column("fecha_control_inicio")]
        public DateTime? FechaControlInicio { get; set; }

        [Column("fecha_control_final")]
        public DateTime? FechaControlFinal { get; set; }

        [Column("fecha_baja")]
        public DateTime? FechaBaja { get; set; }
        public string Documento { get; set; }

        [Column("estado_antecedente_paciente")]
        public bool? EstadoAntecedentePaciente { get; set; }

        [Column("apto_para_atencion")]
        public bool? AptoParaAtencion { get; set; }
        public string Comentarios { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }
        public string Referencias { get; set; }

        [Column("grupo_sanguineo")]
        public string GrupoSanguineo { get; set; }

        [Column("codigo_barras")]
        public string CodigoBarras { get; set; }

        [Column("persona_referencia")]
        public string PersonaReferencia { get; set; }
    }
}
