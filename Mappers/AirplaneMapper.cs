﻿using Entities;
using Mappers.Abstract;
using Model;

namespace Mappers
{
    public class AirplaneMapper 
    {
        public AirplaneModel MapToModel(Airplane entity)
        {
            var model = new AirplaneModel
            {
                Id = entity.Id,
                Company = entity.Company,
                Model = entity.Model,
                DefaultPrice = entity.DefaultPrice,
                Seats = entity.Seats
            };
            return model;
        }

        public Airplane MapToEntity(AirplaneModel model)
        {
            var entity = new Airplane
            {
                Id = model.Id,
                Company = model.Company,
                Model = model.Model,
                DefaultPrice = model.DefaultPrice,
                Seats = model.Seats
            };
            return entity;
        }
    }
}