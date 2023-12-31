﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);

            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);

            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.ProductsListed);
        }

        public IDataResult<Customer> GetById(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(x => x.Id == id), Messages.ProductsListed);
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);

            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
